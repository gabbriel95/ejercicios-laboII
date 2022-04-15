using System;
using Biblioteca;

namespace Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AutoF1 a1 = new AutoF1(1, "escudero1");
            AutoF1 a2 = new AutoF1(32, "escudero2");
            AutoF1 a3 = new AutoF1(23, "escudero3");
            AutoF1 a4 = new AutoF1(45, "escudero4");
            AutoF1 a5 = new AutoF1(13, "escudero5");
            AutoF1 a6 = new AutoF1(123, "escudero6");
            Competencia competencia = new Competencia(12,4);

            if (competencia + a1) 
            {
                Console.WriteLine(a1.mostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");
            }
            if (competencia + a2)
            {
                Console.WriteLine(a2.mostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");


            }
            if (competencia + a3)
            {
                Console.WriteLine(a3.mostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");

            }
            if (competencia + a4)
            {
                Console.WriteLine(a4.mostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");

            }
            if (competencia + a5)
            {
                Console.WriteLine(a5.mostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");


            }
            if (competencia + a6)
            {
                Console.WriteLine(a6.mostrarDatos());
            }
            else
            {
                Console.WriteLine("No se agrego");

            }

           
        }
    }
}
