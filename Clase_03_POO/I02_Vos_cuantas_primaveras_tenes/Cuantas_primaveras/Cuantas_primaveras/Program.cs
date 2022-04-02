using System;
using Biblioteca;

namespace Cuantas_primaveras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Juan", "23/01/1995", 35880457);
            Persona personaDos = new Persona("Ana", "03/11/2015", 37457578);
            Persona personaTres = new Persona("Diego", "11/12/1967", 17645976);

            Console.WriteLine($"{personaUno.Mostrar()}\n{personaUno.EsMayorDeEdad()}\n\n");
            Console.WriteLine($"{personaDos.Mostrar()}\n{personaDos.EsMayorDeEdad()}\n\n");
            Console.WriteLine($"{personaTres.Mostrar()}\n{personaTres.EsMayorDeEdad()}\n\n");
           
        }
    }
}
