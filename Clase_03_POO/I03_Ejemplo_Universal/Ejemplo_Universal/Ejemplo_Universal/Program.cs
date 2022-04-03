using System;
using Biblioteca;

namespace Ejemplo_Universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante alumnoA = new Estudiante("Maria", "Fernandez", "200");
            Estudiante alumnoB = new Estudiante("Jose", "Perez", "201");
            Estudiante alumnoC = new Estudiante("Alejandro", "Anchorena", "202");

            alumnoA.setNotaPrimerParcial(10);
            alumnoA.setNotaSegundoParcial(7);
            alumnoB.setNotaPrimerParcial(8);
            alumnoB.setNotaSegundoParcial(7);
            alumnoC.setNotaPrimerParcial(3);
            alumnoC.setNotaSegundoParcial(1);

            Console.WriteLine($"{alumnoA.Mostrar()}{alumnoB.Mostrar()}{alumnoC.Mostrar()}");
            
        }
    }
}
