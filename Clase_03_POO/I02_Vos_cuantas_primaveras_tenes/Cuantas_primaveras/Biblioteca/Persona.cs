using System;
using System.Text;
using System.Globalization;

namespace Biblioteca
{
    public class Persona
    {
        private string name;
        private string fechaNacimiento;
        private uint dni;

        public Persona(string name, string fechaNacimiento, uint dni)
        {
            this.name = name;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string GetName()
        {
            return this.name;
        }

        public void SetName(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                this.name = value;
            }
        }

        public string GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        public void SetFechaNacimiento(string fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public long GetDni()
        {
            return this.dni;
        }

        public void SetDni(uint value)
        {
            if (value > 0)
            {
                this.dni = value;
            }
        }

        private int CalcularEdad(string fechaNacimiento) 
        {
            double cantidadDias;
            string format = "dd/MM/yyyy";
            int edad;
            DateTime nacimiento = DateTime.ParseExact(fechaNacimiento, format, CultureInfo.InvariantCulture);
        
            TimeSpan diferenciaEntreFechas = DateTime.Now - nacimiento;
            cantidadDias = diferenciaEntreFechas.TotalDays;
            edad = (int)cantidadDias / 365;

            return edad;
        }

        public string Mostrar() 
        {
            int edad = CalcularEdad(this.fechaNacimiento);
            return $"Nombre: {this.name}\nFecha de nacimiento: {this.fechaNacimiento}\nDNI: {this.dni}\nEdad: {edad}";
        }

        public string EsMayorDeEdad()
        {
            int edad = CalcularEdad(this.fechaNacimiento);
            StringBuilder mensaje = new StringBuilder("Es menor de edad");

            if (edad >= 18) 
            {
                mensaje.Clear();
                mensaje.Append("Es mayor de edad");
            }

            return mensaje.ToString();
        }



    }


}
