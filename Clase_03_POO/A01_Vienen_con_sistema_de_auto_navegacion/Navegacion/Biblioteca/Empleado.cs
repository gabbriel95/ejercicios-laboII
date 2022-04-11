using System;

namespace Biblioteca
{
    public class Empleado
    {
        private string nombreEmpleado;
        private int[] arrayDias = new int[7];
        private int acumuladorKm = 0;


        public void SetDias()
        {
            string aux;

            for (int i = 0; i < this.arrayDias.Length; i++)
            {
                Console.WriteLine($"Ingrese los Km del dia {i + 1}:");
                aux = Console.ReadLine();
                int.TryParse(aux, out this.arrayDias[i]);
                acumuladorKm += this.arrayDias[i];
            }
        }

        public int GetKmDia(int dia)
        {


            return this.arrayDias[dia];


        }

        public void SetNombreEmpleado()
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            this.nombreEmpleado = Console.ReadLine();

        }

        public string GetNombreEmpleado()
        {
            return this.nombreEmpleado;
        }

        public int GetAcumuladorKm()
        {
            return this.acumuladorKm;

        }

        public static string CalcularMaximoConductorXSemana(Empleado[] empleado)
        {
            string nombreEmpleado = null;
            int km = 0;

            for (int i = 0; i < empleado.Length; i++)
            {
                if (i == 0)
                {
                    km = empleado[0].GetAcumuladorKm();
                    nombreEmpleado = empleado[0].nombreEmpleado;
                }
                else if (km < empleado[i].acumuladorKm)
                {
                    km = empleado[i].GetAcumuladorKm();
                    nombreEmpleado = empleado[i].nombreEmpleado;
                }

            }

            return nombreEmpleado;

        }

        public static string CalcularMaximoKmXDia(Empleado[] empleado, int dia)
        {
            string nombreEmpleado = null;
            int km = 0;

            for (int i = 0; i < empleado.Length; i++)
            {
                if (i == 0)
                {
                    km = empleado[0].GetKmDia(dia-1);
                    nombreEmpleado = empleado[0].nombreEmpleado;
                   
                }
                else if (km < empleado[i].GetKmDia(dia-1))
                {
                    km = empleado[i].GetKmDia(dia-1);
                    nombreEmpleado = empleado[i].nombreEmpleado;
                }

            }

            return nombreEmpleado;

        }



    }
}