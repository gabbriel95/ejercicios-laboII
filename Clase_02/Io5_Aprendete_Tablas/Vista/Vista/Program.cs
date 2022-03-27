using System;
using LogicaNegocio;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
      
            numero = pedirNumero();

            Console.WriteLine(Tablas.MostrarTabla(numero));
        }
        public static int pedirNumero() {

            string numeroString;
            int numero;
            do
            {
                Console.WriteLine("Ingrese un numero para mostrar su tabla");
                numeroString = Console.ReadLine();

            } while (!int.TryParse(numeroString, out numero));


            return numero;
        } 
    }

}
