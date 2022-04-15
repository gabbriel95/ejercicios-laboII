using System;
using System.Collections.Generic;

namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            Stack<int> stackPositivos = new Stack<int>();
            Stack<int> stackNegativos = new Stack<int>();
            Queue<int> queueNegativos = new Queue<int>();
            Queue<int> queuePositivos = new Queue<int>();

            Random random = new Random();

            for (int i = 0; i < 20; i++)
            {
                lista.Add(random.Next(-100,100));  
            }
            
            Console.WriteLine("Lista original");
            foreach (int i in lista) 
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Lista Ordenada decreciente");
            lista.Sort(OrdenDescendente);
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Lista Positivos");
            foreach (int i in lista) 
            {
                if (i > 0)
                {
                    Console.WriteLine(i);
                    queuePositivos.Enqueue(i);
                }
                else if (i < 0) 
                {
                    stackNegativos.Push(i);
                }
            }

            Console.WriteLine("Lista Negativos");
            foreach (int i in lista)
            {
                if (i > 0)
                {
                    stackPositivos.Push(i);
                }
                else if (i < 0) 
                {
                    Console.WriteLine(i);
                    queueNegativos.Enqueue(i);
                }
            }

            Console.WriteLine(" Cola Positivos");
            foreach (int i in queuePositivos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Pila Positivos");
            foreach (int i in stackPositivos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Cola Negativos");
            foreach (int i in queueNegativos)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(" Pila Negativos");
            foreach (int i in stackNegativos)
            {
                Console.WriteLine(i);
            }

        }

        public static int OrdenDescendente(int a, int b)
        {
            return b - a;
        }
    }
}
