using System;
using Biblioteca;

namespace Vista
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primerOperando;
            int segundoOperando;
            string tipoOperacion;
            int resultado;
            string respuesta;

            do
            {
                primerOperando = PedirOperandos("primer");
                segundoOperando = PedirOperandos("segundo");
                tipoOperacion = PedirOperador();
   
                resultado = Calculadora.Calcular(primerOperando,segundoOperando,tipoOperacion);

                Console.WriteLine($"\nResultado: {primerOperando} {tipoOperacion} {segundoOperando} = {resultado}");

                Console.WriteLine("\nDesea realizar otra operacion? \n[S: Para continuar] // [Cualquier tecla: Para salir]");
                respuesta = Console.ReadLine();

            } while (respuesta == "S" || respuesta == "s");

        }

        static int PedirOperandos(string posicionOperando) {

            int numero;
            string numeroString;

            do
            {
                Console.WriteLine($"Ingrese el {posicionOperando} operando");
                numeroString = Console.ReadLine();

            } while (!int.TryParse(numeroString, out numero));

            return numero;
        }

        static string PedirOperador() {

            string operador;

            do
            {
                Console.WriteLine("Ingrese el tipo de operacion que desea realizar [ + ; - ; / ; *]");
                operador = Console.ReadLine();

            } while (operador != "+" && operador != "-" && operador != "*" && operador != "/");

            return operador;
        }

        
    }
}
