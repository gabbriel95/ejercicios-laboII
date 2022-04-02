using System;
using LogicaNegocio;

namespace Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            float promedio;
            int acumulador = 0;

            for (int i = 0; i < 10; i++)
            {
                do
                {
                    numeroIngresado = PedirNumero();
                  
                } while (!LogicaNegocio.Validador.Validar(numeroIngresado, -100, 100));

                if (i == 0)
                {
                    numeroMinimo = numeroIngresado;
                    numeroMaximo = numeroIngresado;
                }
                else if (numeroIngresado > numeroMaximo)
                {
                    numeroMaximo = numeroIngresado;
                }
                else if (numeroIngresado < numeroMinimo) { 
                    numeroMinimo = numeroIngresado;
                }

                acumulador += numeroIngresado;
            }

            promedio = CalcularPromedio(acumulador, 10);

            Console.WriteLine($"El numero minimo ingresado es {numeroMinimo} y el numero maximo ingresado es {numeroMaximo}, el promedio es {promedio}");

        }
        private static int PedirNumero()
        {

            string numeroString;
            int numeroIngresado;

            do
            {
                Console.WriteLine("Ingrese un número");
                numeroString = Console.ReadLine();

            } while (!int.TryParse(numeroString, out numeroIngresado));

            return numeroIngresado;
        }

        private static float CalcularPromedio(int dividendo, int divisor) {

            float resultado = (float) dividendo / divisor;

            return resultado;
        }

    }


}
