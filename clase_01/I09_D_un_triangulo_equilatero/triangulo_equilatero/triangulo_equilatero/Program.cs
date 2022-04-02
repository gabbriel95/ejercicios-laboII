using System;
using System.Linq;

namespace triangulo_equilatero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string alturaString;
            string asterisco;
            int contador = 1;
            int espacios = 55;
            string resultado;


            do
            {
                Console.WriteLine("Ingrese un numero");
                alturaString = Console.ReadLine();

            } while (!int.TryParse(alturaString, out altura) || altura > 55);


            for (int i = 1; i < altura; i++)
            {
                asterisco = String.Concat(Enumerable.Repeat("*", contador));
                resultado = String.Concat(Enumerable.Repeat(" ", espacios));

                Console.Write($"{resultado}");

                if (espacios > 0) {
                    espacios -= 1;
                }

                Console.Write($"{asterisco}");
                contador += 2;
                Console.Write("\n");
            }
        }
    }
}
