using System;
using Biblioteca;

/*
 El factorial de un número es una operación que consiste en multiplicar un numero “n” 
por todos los números enteros positivos que estén debajo de él, por ejemplo el factorial
de 3 es el resultado de multiplicar 3 por 2 por 1.

En una aplicación de consola, desarrollar un método estático que calcule el factorial
de un número dado.
 */
namespace Vision
{
    internal class Vision
    {
        static void Main(string[] args)
        {
            int numero;
            int factorial;
            do
            {
               numero = pedirNumeroEntero("Ingrese un numero positivo para calcular el factorial");

            } while (numero < 0);

            factorial = Factorial.CalcularFactorial(numero);
            Console.WriteLine(factorial);
        }

        public static int pedirNumeroEntero(string texto)
        {
            int numero;
            string numeroString;

            do
            {
                Console.WriteLine(texto);
                numeroString = Console.ReadLine();

            } while (!int.TryParse(numeroString, out numero));



            return numero;
        }
    }

}
