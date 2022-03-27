using System;

namespace Biblioteca
{
    public static class Calculadora
    {
        public static int Calcular(int primerOperando, int segundoOperando, string operacion) {

            int resultado = 0;

            if (operacion == "+")
            {
                resultado = primerOperando + segundoOperando;
            }
            else if (operacion == "-")
            {
                resultado = primerOperando - segundoOperando;
            }
            else if (operacion == "*")
            {
                resultado = primerOperando * segundoOperando;
            }
            else {

                if (Validar(segundoOperando))
                {

                    resultado = primerOperando / segundoOperando;
                }
                else {
                    Console.WriteLine("No se puede dividir por cero");
                }
            }

            return resultado;
        }

        public static bool Validar(int segundoOperando) {

            bool validador = false;

            if (segundoOperando != 0) {

                validador = true;
            }

            return validador;
        }
    }
}
