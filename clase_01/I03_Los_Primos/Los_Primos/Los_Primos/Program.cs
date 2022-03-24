using System;
/*
 Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.

Validar que el dato ingresado por el usuario sea un número.

Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

Si ingresa "salir", cerrar la consola.

Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar.
De lo contrario, cerrar la consola.*/
namespace Los_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            short numeroIngresado;
            string respuesta;

            int n = 2;
            int total = 2;
            bool esPrimo;

            do
            {
                Console.WriteLine("Ingrese un numero");
                respuesta = Console.ReadLine();

                if (respuesta == "salir" || respuesta == "SALIR" || respuesta == "Salir")
                {
                    Environment.Exit(0);
                }

            } while (!short.TryParse(respuesta, out numeroIngresado));


            while (total <= numeroIngresado)
            {
                esPrimo = true;

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(n);

                }
                total++;
                n++;
            }


        }
    }
}