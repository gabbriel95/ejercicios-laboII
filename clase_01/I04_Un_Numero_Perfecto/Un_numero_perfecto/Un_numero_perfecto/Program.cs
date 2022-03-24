using System;

namespace RangoPerfectos
{
    class Program
    {
        static void Main(string[] args)
        {
            int acumulador; int num; int j;
            int contadorPerfectos = 0;

            num = Int16.MaxValue;

            if (contadorPerfectos <= 4) 
            {
                for (int i = 1; i <= num; i++)
                {
                    acumulador = 0;

                    for (j = 1; j <= (i / 2); j++)
                    {
                        if (i % j == 0)
                        {
                            acumulador += j;
                        }
                    }
                    if (acumulador == i)
                    {
                        contadorPerfectos++;
                        Console.WriteLine($"Numero perfecto #{contadorPerfectos} es el numero {i} es perfecto");
                    }
                }
            }
        }
    }
}