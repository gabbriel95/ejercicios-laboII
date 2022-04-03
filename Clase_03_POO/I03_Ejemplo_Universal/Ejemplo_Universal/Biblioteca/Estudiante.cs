using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string nombre;
        private string legajo;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()
        {
            Estudiante.random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.legajo = legajo;
            this.apellido = apellido;
        }

        public void setNotaPrimerParcial(int value)
        {
            if (value > 0 && value < 11)
            {
                this.notaPrimerParcial = value;

            }
        }

        public void setNotaSegundoParcial(int value)
        {
            if (value > 0 && value < 11)
            {
                this.notaSegundoParcial = value;

            }
        }

        private double CalcularPromedio(int numeroA, int numeroB) 
        {
            double promedio = (numeroA + numeroB) / 2;

            return promedio;
        }

        public double CalcularNotaFinal() 
        {
            double notaFinal = -1;

            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4) 
            {
                notaFinal = random.Next(6, 11);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder($"Nombre:{this.nombre}\nApellido:{this.apellido}\nLegajo:{this.legajo}\nNota del primer parcial:{this.notaPrimerParcial}\nNota del segundo parcial: {this.notaSegundoParcial}\nPromedio:{CalcularPromedio(this.notaPrimerParcial,this.notaSegundoParcial)}\n");
            double notaFInal = CalcularNotaFinal();
            if (notaFInal != -1)
            {
                mensaje.AppendLine($"Nota final:{notaFInal}\n\n");
            }
            else 
            {
                mensaje.AppendLine("Alumno desaprobado\n\n");
            }
            return mensaje.ToString();
        }

    }
}
