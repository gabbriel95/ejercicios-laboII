using System;
/*
 Ingresar un número y mostrar el cuadrado y el cubo del mismo. 
Se debe validar que el número sea mayor que cero, caso contrario, 
mostrar el mensaje: "ERROR. ¡Reingresar número!".
 */
namespace Error_al_cubo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resultadoAlCubo;
            double resultadoAlCuadrado;
            double numero;
            string numeroAux;


            do { 
                Console.WriteLine("Ingrese un numero");
                numeroAux = Console.ReadLine();

                if (double.TryParse(numeroAux, out numero) && numero > 0)
                {
                    resultadoAlCuadrado = Math.Pow(numero, 2);
                    resultadoAlCubo = Math.Pow(numero, 3);
                    Console.WriteLine($"El cuadrado de {numero} es {resultadoAlCuadrado} y el cubo es {resultadoAlCubo}");
                }
                else 
                {
                    Console.WriteLine("ERROR. ¡Reingresar número!");
                }
            
            }while (!double.TryParse(numeroAux, out numero) || numero <= 0);
            
        }
    }
}
