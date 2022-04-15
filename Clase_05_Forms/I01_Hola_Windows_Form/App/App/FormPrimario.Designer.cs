namespace App
{
    partial class FormPrimario
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.btnSaludar = new System.Windows.Forms.Button();
            this.cmbMateriaFav = new System.Windows.Forms.ComboBox();
            this.lblMateriaFav = new System.Windows.Forms.Label();
            this.lvlErrorNombre = new System.Windows.Forms.Label();
            this.lvlErrorApellido = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(79, 152);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(183, 23);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombre_KeyPress);
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Location = new System.Drawing.Point(79, 236);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(183, 23);
            this.textBoxApellido.TabIndex = 1;
            this.textBoxApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellido_KeyPress);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelNombre.Location = new System.Drawing.Point(79, 102);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(130, 37);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelApellido.Location = new System.Drawing.Point(79, 188);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(133, 37);
            this.labelApellido.TabIndex = 3;
            this.labelApellido.Text = "Apellido:";
            // 
            // btnSaludar
            // 
            this.btnSaludar.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaludar.Location = new System.Drawing.Point(331, 178);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(211, 81);
            this.btnSaludar.TabIndex = 4;
            this.btnSaludar.Text = "Saludar!";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.buttonSaludar_Click);
            // 
            // cmbMateriaFav
            // 
            this.cmbMateriaFav.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMateriaFav.FormattingEnabled = true;
            this.cmbMateriaFav.Location = new System.Drawing.Point(79, 333);
            this.cmbMateriaFav.Name = "cmbMateriaFav";
            this.cmbMateriaFav.Size = new System.Drawing.Size(183, 23);
            this.cmbMateriaFav.TabIndex = 5;
            // 
            // lblMateriaFav
            // 
            this.lblMateriaFav.AutoSize = true;
            this.lblMateriaFav.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMateriaFav.Location = new System.Drawing.Point(79, 279);
            this.lblMateriaFav.Name = "lblMateriaFav";
            this.lblMateriaFav.Size = new System.Drawing.Size(234, 37);
            this.lblMateriaFav.TabIndex = 6;
            this.lblMateriaFav.Text = "Materia favorita:";
            // 
            // lvlErrorNombre
            // 
            this.lvlErrorNombre.AutoSize = true;
            this.lvlErrorNombre.ForeColor = System.Drawing.Color.Red;
            this.lvlErrorNombre.Location = new System.Drawing.Point(78, 178);
            this.lvlErrorNombre.Name = "lvlErrorNombre";
            this.lvlErrorNombre.Size = new System.Drawing.Size(110, 15);
            this.lvlErrorNombre.TabIndex = 7;
            this.lvlErrorNombre.Text = "Error, solo números";
            this.lvlErrorNombre.Visible = false;
            // 
            // lvlErrorApellido
            // 
            this.lvlErrorApellido.AutoSize = true;
            this.lvlErrorApellido.ForeColor = System.Drawing.Color.Red;
            this.lvlErrorApellido.Location = new System.Drawing.Point(79, 262);
            this.lvlErrorApellido.Name = "lvlErrorApellido";
            this.lvlErrorApellido.Size = new System.Drawing.Size(110, 15);
            this.lvlErrorApellido.TabIndex = 8;
            this.lvlErrorApellido.Text = "Error, solo números";
            this.lvlErrorApellido.Visible = false;
            // 
            // FormPrimario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvlErrorApellido);
            this.Controls.Add(this.lvlErrorNombre);
            this.Controls.Add(this.lblMateriaFav);
            this.Controls.Add(this.cmbMateriaFav);
            this.Controls.Add(this.btnSaludar);
            this.Controls.Add(this.labelApellido);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPrimario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hola, Windows Form!";
            this.Load += new System.EventHandler(this.FormPrimario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.ComboBox cmbMateriaFav;
        private System.Windows.Forms.Label lblMateriaFav;
        private System.Windows.Forms.Label lvlErrorNombre;
        private System.Windows.Forms.Label lvlErrorApellido;
    }
}
