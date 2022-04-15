using System;
using Billetes;

namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Euro billeteEuro = 1;
            Pesos billetePeso = (Pesos)billeteEuro;//Se pasa el euro a pesos
            Dolar billeteDolar = 100;

            Console.WriteLine(billetePeso.GetCantidad());// 1euro x cotizacion dolar, x cotizacion peso seria 1x1.17x120
            billetePeso = (Pesos)billeteDolar;//se tranforman los 100 dolares a pesos 100x120
            Console.WriteLine("La cantidad de Dolares convertidos a pesos {0}", billetePeso.GetCantidad());



        }
    }
}