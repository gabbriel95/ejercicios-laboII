using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class FormPrimario : Form
    {
        public FormPrimario() 
        {
            InitializeComponent();
        }
        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.textBoxApellido.Text) && !string.IsNullOrWhiteSpace(this.textBoxNombre.Text))
            {
                FormSecundario miFrm = new FormSecundario("Hola, Windows Forms!", $"Soy {this.textBoxNombre.Text}, {this.textBoxApellido.Text} y mi materia favorita es {this.cmbMateriaFav.SelectedItem}");
                miFrm.ShowDialog();
            }
            else 
            {
                MessageBox.Show($"Se debe completar los siguientes campos\n {this.textBoxNombre.Name}\n{this.textBoxApellido.Name}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormPrimario_Load(object sender, EventArgs e)
        {
            this.cmbMateriaFav.Items.Add("Programación II");//agrega un item a la list
            this.cmbMateriaFav.Items.Add("Programación I");
            this.cmbMateriaFav.Items.Add("Laboratorio I");
            this.cmbMateriaFav.Items.Add("Laboratorio II");
            this.cmbMateriaFav.SelectedIndex = 0;//selecciona una automaticamente como primera
        }

        private void textBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lvlErrorNombre.Visible = false;
            if (char.IsDigit(e.KeyChar)) 
            {
                e.Handled = true;
                this.lvlErrorNombre.Visible = true;//Podemos controlar que es lo que se ingresa
            }
        }

        private void textBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.lvlErrorNombre.Visible = false;
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                this.lvlErrorApellido.Visible = true;
            }
        }
    }
}
