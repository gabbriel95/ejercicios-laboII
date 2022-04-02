using System;
using Biblioteca;
/*
 Crear una aplicación de consola que pida al usuario ingresar la base y la altura de un triángulo en centímetros.

El programa deberá calcular la longitud de la hipotenusa aplicando el teorema de pitágoras y

Usar los métodos Pow y Sqrt de la clase Math para realizar los cálculos.

Mostrar el resultado en la consola.
 
 */
namespace Vista
{
    internal class Vista
    {
        static void Main(string[] args)
        {
            int baseTriangulo;
            int alturaTriangulo;
            float hipotenusa;

            baseTriangulo = pedirNumeroEntero("Ingrese la base del triangulo en CM");
            alturaTriangulo = pedirNumeroEntero("Ingrese la altura del triangulo en CM");

            hipotenusa = Hipotenusa.calcularHipotenusa(alturaTriangulo, baseTriangulo);

            Console.WriteLine($"La suma de los catetos al cuadrado {alturaTriangulo} + {baseTriangulo} da como resultado la hipotenusa de {hipotenusa:N2}");

          
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


