using System;

namespace triangulo_rectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string alturaString;
            string asterisco = "*";

            do
            {
                Console.WriteLine("Ingrese la altura del triangulo");
                alturaString = Console.ReadLine();
            } while (!int.TryParse(alturaString, out altura) || altura <= 0);

            for (int i = 1; i <= altura; i++) 
            {
                Console.WriteLine($"{asterisco}");
                asterisco += "**";
            }
        }
    }
}
