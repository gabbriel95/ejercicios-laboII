using System;

namespace Biblioteca
{
    public class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            if (tinta > 0)
            {
                if ((this.tinta + tinta) > cantidadTintaMaxima)
                {
                    this.tinta = cantidadTintaMaxima;
                }
                else
                {
                    this.tinta += tinta;
                }
            }
            else if (tinta < 0) 
            {
                if ((this.tinta - tinta) < 0)
                {
                    this.tinta = 0;
                }
                else 
                {
                    this.tinta += tinta;
                }
            }

        }

        public void Recargar()
        {
            this.SetTinta(cantidadTintaMaxima);
        }

        public bool Pintar(short gasto, out string dibujo)
        {
            bool retorno = false;
            string cadenaString = string.Empty;
            short contador = 0;

            if (this.tinta == 0)
            {
                dibujo = "No se puede pintar ya que no se posee tinta";

            }
            else 
            {
                while (gasto > 0 && (this.tinta + contador) > 0) 
                {
                    cadenaString += "*";
                    contador--;
                    gasto--;
                }
                dibujo = cadenaString;
                retorno = true;
                this.SetTinta(contador);
            }

            return retorno;
        }

    }

}
