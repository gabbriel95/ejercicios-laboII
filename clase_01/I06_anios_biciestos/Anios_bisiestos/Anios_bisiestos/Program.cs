using System;
/*
 * Escribir un programa que determine si un año es bisiesto.

Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos,
salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.

Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
 */
namespace Anios_bisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int inicio;
            string inicioString;
            int final;
            string finalSting;
            bool repetir;
            short contadorAñosBiciestos = 0;

            do
            {
                do
                {  
                    Console.WriteLine("Ingrese el año de inicio");
                    inicioString = Console.ReadLine();

                    Console.WriteLine("Ingrese el año de fin");
                    finalSting = Console.ReadLine();
                    repetir = false;

                } while (!int.TryParse(inicioString, out inicio) || !int.TryParse(finalSting, out final));

                if (inicio > final) 
                {
                    Console.WriteLine("ERROR!. La fecha inicial es mayor a la fecha final.");
                    repetir = true;
                } 

            } while (repetir);

            while (inicio <= final) 
            {
                if (inicio % 4 == 0 && (!(inicio % 100 == 0) || (inicio % 400 == 0)))
                {
                 
                        contadorAñosBiciestos++;
                        Console.WriteLine($"{inicio} es año biciesto");         
                       
                }

                inicio = inicio + 4;
            }

            Console.WriteLine($"Entre las fechas ingresadas hay {contadorAñosBiciestos} años biciestos");

        }
    }
}
