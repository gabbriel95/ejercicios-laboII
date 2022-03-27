using System;

namespace LogicaNegocio
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) {
            
            string numeroBinario = "";
            int divisor = 2;
            int resto;

            for (int i = 0; numeroEntero >= divisor; i++)
            {
                resto = numeroEntero % 2;
                numeroEntero = numeroEntero / divisor;

                numeroBinario += resto;

                if (numeroEntero < divisor)
                {
                    numeroBinario += numeroEntero;
                    numeroBinario = Reverse(numeroBinario);
                  
                }
            }


            return numeroBinario;
        }

        private static string Reverse(string text) {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public static int ConvertirBinarioADecimal(int numeroEntero) {
            int numeroDecimal = 0;
            string numeroString = numeroEntero.ToString();
            int numeroIndividual;
            double multiplicador = 0;
            int acumulador = 0;

            for (int i = 0; i < numeroString.Length; i++)
            {
                int.TryParse(numeroString.Substring(i, 1), out numeroIndividual);
                multiplicador = Math.Pow(2, (numeroString.Length-1)-i);
                acumulador += Convert.ToInt32(multiplicador * numeroIndividual);
            }
       


            return acumulador;
        }
    }
}
