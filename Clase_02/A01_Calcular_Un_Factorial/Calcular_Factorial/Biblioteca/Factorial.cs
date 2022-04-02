using System;

namespace Biblioteca
{
    public class Factorial
    {
        public static int CalcularFactorial(int numero)
        {
            int resultado = 1;

            if (numero == 0)
            {
                resultado = 1;
            }
            else
            {
                for (int i = 1; i <= numero; i++)
                {
                    resultado *= i;
                }
            }

            return resultado;
        }
    }
}
