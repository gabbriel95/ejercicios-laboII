using System;
using LogicaNegocio;

namespace I02_Desea_Continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            string numeroIngresadoString;
            string respuesta;
            int acumulador = 0;


            do
            {
                do
                {
                    Console.WriteLine("Ingrese un numero");
                    numeroIngresadoString = Console.ReadLine();

                } while (!int.TryParse(numeroIngresadoString, out numeroIngresado));

                acumulador = Suma(acumulador, numeroIngresado);

                Console.WriteLine("Desea sumar otro numero?");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));


            Console.WriteLine($"La suma de todos los numeros ingresados es {acumulador}");


        }

        static int Suma(int numeroUno, int numeroDos)
        {
            int resultado = numeroUno + numeroDos;

            return resultado;
        }
    }
}
