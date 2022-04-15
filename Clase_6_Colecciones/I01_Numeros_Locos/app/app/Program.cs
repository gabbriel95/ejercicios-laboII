using System;

namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            Random aleatorio = new Random();

            Console.WriteLine("Array original:");
            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = aleatorio.Next(-100, 100);
                Console.WriteLine("{0} : {1}", i, numeros[i]);
            }

            Array.Sort(numeros, Program.Comparar);

            Console.WriteLine("Array positivos de forma decreciente:");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] > 0) 
                {
                    Console.WriteLine("{0} : {1}", i, numeros[i]);

                }
            }

            Array.Sort(numeros);

            Console.WriteLine("Array negativos de forma creciente:");
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] < 0)
                {
                    Console.WriteLine("{0} : {1}", i, numeros[i]);

                }
            }
        }
        public static int Comparar(int a, int b)
        {
            return b - a;
            /*Si A es mayor a B devuelve un positivo
             Si A es menor a B devielve un negativo
            Si son iguales devuelve 0*/
        }

    }
}
