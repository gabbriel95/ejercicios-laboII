using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numero = Conversor.ConvertirDecimalABinario(PedirNumeroDecimal());
            Console.WriteLine($"{numero}");

            int numero2 = Conversor.ConvertirBinarioADecimal(PedirNumeroBinario());
            Console.WriteLine($"{numero2}");
        }

        private static int PedirNumeroDecimal()
        {

            string numeroString;
            int numeroIngresado;

            do
            {
                Console.WriteLine("Ingrese un número decimal");
                numeroString = Console.ReadLine();

            } while (!int.TryParse(numeroString, out numeroIngresado));

            return numeroIngresado;
        }

        private static int PedirNumeroBinario()
        {

            string numeroString;
            int numeroIngresado;

            do
            {
                Console.WriteLine("Ingrese un número binario");
                numeroString = Console.ReadLine();

            } while (!int.TryParse(numeroString, out numeroIngresado));

            return numeroIngresado;
        }
    }
}
