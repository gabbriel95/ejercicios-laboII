using System;
using Geometria;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punto p1 = new Punto(2, 2);
            Punto p2 = new Punto(4, 6);

            Rectangulo r = new Rectangulo(p1, p2);

            Console.WriteLine("                      ");
            Console.WriteLine("Datos del Rectángulo  ");
            Console.WriteLine();
            Console.BackgroundColor
                = ConsoleColor.Blue;
            Console.WriteLine("                      ");
            Console.WriteLine("Area:                " + r.GetArea());
            Console.WriteLine("Perimetro:          " + r.GetPerimetro());
            Console.WriteLine("                      ");
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Pulse una tecla para Terminar");
            Console.ReadKey();
        }
    }
}
