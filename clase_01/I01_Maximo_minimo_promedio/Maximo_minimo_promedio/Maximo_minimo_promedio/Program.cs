using System;

namespace Maximo_Minimo_Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string numeroTexto;
            int numeroMaximo = 0;
            int numeroMinimo = 0;
            float promedio;
            int acumulador = 0;

            for (int i = 0; i < 5; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese un número: ");
                    numeroTexto = Console.ReadLine();

                } while (!int.TryParse(numeroTexto, out numero));

                if (i == 0)
                {
                    numeroMaximo = numero;
                    numeroMinimo = numero;
                }
                else 
                {
                    if (numero > numeroMaximo) 
                    {
                        numeroMaximo = numero;
                    }
                    if (numero < numeroMinimo) 
                    {
                        numeroMinimo = numero;
                    }
                }

                acumulador += numero;
            }

            
            promedio = (float)acumulador / 5;

            Console.WriteLine($"El numero maximo ingresado es {numeroMaximo} y el numero minimo ingreso es {numeroMinimo}. El promedio de los cinco números ingresados es {promedio}");
        }
    }
}