using System;

namespace Biblioteca
{
    public class Factorial
    {
        public static int CalcularFactorial(int numero) 
        {
            int resultado;

            if (numero == 0)
            {
                resultado = 1;
            }
            else 
            {
                resultado = numero;
            }

            return resultado;
        }
    }
}
