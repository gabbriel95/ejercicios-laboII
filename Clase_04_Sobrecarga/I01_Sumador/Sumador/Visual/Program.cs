using System;
using Biblioteca;

namespace Visual
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumador2 = new Sumador(2);

            Console.WriteLine($"Suma long {sumador.Sumar(20, 10)} ");
            Console.WriteLine($"Suma string {sumador.Sumar("Hola ", "Mundo")} ");


            Console.WriteLine($"La suma de cantidadSumas de cada objeto es {sumador + sumador2}");

            if (sumador | sumador2)
            {
                Console.WriteLine("True");
            }
            else 
            {
                Console.WriteLine("False");
            
            }


        }
    }
}
