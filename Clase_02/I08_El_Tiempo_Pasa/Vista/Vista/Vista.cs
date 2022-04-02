using System;
using Biblioteca;
/*
 Crear un método estático que reciba una fecha y calcule el número de días
que pasaron desde esa fecha hasta la fecha actual.
Tener en cuenta los años bisiestos.

Pedir por consola la fecha de nacimiento de una persona (día, mes y año) y 
calcule el número de días vividos por esa persona hasta la fecha actual
utilizando el método desarrollado anteriormente.

Ayudarse con las funcionalidades del tipo DateTime para resolver el ejercicio.
 */
namespace Vista
{
    internal class Vista
    {
        static void Main(string[] args)
        {

            int anio;
            int mes;
            int dia;
            DateTime fechaNacimiento;
            double diasDesdeNacimiento;


            anio = pedirNumeroEntero("Ingrese el año de nacimiento");
            mes = pedirNumeroEntero("Ingrese el mes de nacimiento");
            dia = pedirNumeroEntero("Ingrese el dia de nacimiento");

            fechaNacimiento = new DateTime(anio,mes,dia);
            diasDesdeNacimiento = ConversorFecha.ConvierteFechaADia(fechaNacimiento);
            Console.WriteLine($"Desde la fecha de su nacimiento han pasado {diasDesdeNacimiento:N0} dias");
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
