using System;
using Biblioteca;

namespace Invento_Argentino
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleColor colorOriginal = Console.ForegroundColor;
            string dibujo;

            Boligrafo boliAzul = new Boligrafo(30, ConsoleColor.Blue);
            Boligrafo boliRojo = new Boligrafo(50, ConsoleColor.Red);
            Console.ForegroundColor = boliAzul.GetColor();
            boliAzul.Pintar(10, out dibujo);
            Console.WriteLine(dibujo);
            Console.WriteLine($"El nivel de tinta restante del boli azul es {boliAzul.GetTinta()}");
            boliAzul.Pintar(24, out dibujo);
            Console.WriteLine(dibujo);
            Console.ForegroundColor = colorOriginal;
            Console.WriteLine($"El nivel de tinta restante del boli azul es {boliAzul.GetTinta()}");
            boliAzul.Pintar(40, out dibujo);
            Console.WriteLine(dibujo);
            Console.ForegroundColor = colorOriginal;
        }
    }
}
