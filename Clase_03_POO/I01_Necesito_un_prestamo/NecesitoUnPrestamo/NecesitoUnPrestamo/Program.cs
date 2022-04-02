using System;
using Entidades;

namespace NecesitoUnPrestamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta UTN = new Cuenta("UTN", 1000);

            Console.WriteLine(UTN.Mostrar());

            UTN.Ingresar(300);
            Console.WriteLine(UTN.Mostrar());

            UTN.Ingresar(-200);
            Console.WriteLine(UTN.Mostrar());

            UTN.Retirar(500);
            Console.WriteLine(UTN.Mostrar());
        }
    }
}
