using System;
using System.Text;

namespace LogicaNegocio
{
    public class Tablas
    {
        public static string MostrarTabla(int numero) {

            StringBuilder resultadoString = new StringBuilder();
            int resultado;

            for (int i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                resultadoString.AppendLine($"{numero} * {i} = {resultado}");

            }
          

            return resultadoString.ToString();
        }

    }
}
