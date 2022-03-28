using System;
using LogicaNegocio;

namespace Vista
{
    public static class Program
    {
        static void Main(string[] args)
        {
            string respuesta;
            double resultado;
            double basse;
            double altura;
            double radio;
            bool validacion;

            do
            {
                Console.WriteLine("Seleccione el area de que figura desea encontrar: \n 1_Area de un triangulo \n 2_Area de un cuadrado \n 3_Area de un circulo");
                respuesta = Console.ReadLine();

            } while (respuesta != "1" && respuesta != "2" && respuesta != "3");


            switch (respuesta)
            {
                case "1":
                    do
                    {
                        Console.WriteLine("Ingrese la base del triangulo");
                        validacion = double.TryParse(Console.ReadLine(), out basse);
                    } while (!validacion);

                    do
                    {
                        Console.WriteLine("Ingrese la altura del triangulo");
                        validacion = double.TryParse(Console.ReadLine(), out altura);
                    } while (!validacion);

                    resultado = CalculadoraDeAreas.CalcularAreaTriangulo(basse, altura);
                    Console.WriteLine($"El area del triangulo es {resultado}");
                    break;
                case "2":
                    do
                    {
                        Console.WriteLine("Ingrese la altura del cuadrado");
                        validacion = double.TryParse(Console.ReadLine(), out altura);

                    } while (!validacion);

                    resultado = CalculadoraDeAreas.CalcularAreaCuadrado(altura);
                    Console.WriteLine($"El area del cuadrado es {resultado}");

                    break;
                case "3":
                    do
                    {
                        Console.WriteLine("Ingrese el radio del circulo");
                        validacion = double.TryParse(Console.ReadLine(), out radio);

                    } while (!validacion);

                    resultado = CalculadoraDeAreas.CalcularAreaCirculo(radio);
                    Console.WriteLine($"El area del circulo es {resultado}");

                    break;
                default:
                    break;
            }

        }
    }
}
