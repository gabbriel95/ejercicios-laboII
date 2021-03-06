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


            int numeroPrimo;
            bool esPrimo;

            do
            {
                numeroPrimo = 2;
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    respuesta = Console.ReadLine();

                    if (respuesta == "salir" || respuesta == "SALIR" || respuesta == "Salir")
                    {
                        Environment.Exit(0);
                    }

                } while (!short.TryParse(respuesta, out numeroIngresado));


                while (numeroPrimo <= numeroIngresado)
                {
                    esPrimo = true;

                    for (int i = 2; i < numeroPrimo; i++)
                    {
                        if (numeroPrimo % i == 0)
                        {
                            esPrimo = false;
                            break;
                        }
                    }

                    if (esPrimo)
                    {
                        Console.WriteLine(numeroPrimo);

                    }
                    numeroPrimo++;
                }


                Console.WriteLine("Desea volver a operar? [S/N]");
                respuesta = Console.ReadLine();

            } while (respuesta == "s" || respuesta == "S");
           
        }
    }
}