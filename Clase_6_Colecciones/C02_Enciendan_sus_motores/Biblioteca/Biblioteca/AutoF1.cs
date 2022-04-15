using System;
using System.Text;

namespace Biblioteca
{
    public class AutoF1
    {
        private short cantidadCombustible;
        private bool enCompetencia;
        private string escuderia;
        private short numero;
        private short vueltasRestantes;


        public AutoF1(short cantidadCombustible, short vueltasRestantes, bool enCompetencia)
        {
            this.cantidadCombustible = cantidadCombustible;
            this.vueltasRestantes = vueltasRestantes;
            this.enCompetencia = enCompetencia;
        }
        public AutoF1(short numero, string escuderia) : this(0,0,false)
        {
            this.numero = numero;
            this.escuderia = escuderia;
        }

        public string mostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Auto: " + this.numero);
            sb.AppendLine("Escuderia: " + this.escuderia);
            sb.AppendLine("Vueltas Restantes: " + this.vueltasRestantes);
            sb.AppendLine("Cantidad de combustible: " + this.cantidadCombustible);
            return sb.ToString();
        }

        public void setCantidadCombustible(short cantidadCombustible) 
        {
            this.cantidadCombustible = cantidadCombustible;
        }

        public short getCantidadCombustible()
        {
            return this.cantidadCombustible;
        }

        public void setEnCompetencia(bool enCompetencia)
        {
            this.enCompetencia = enCompetencia;
        }

        public bool getEnCompetencia()
        {
            return this.enCompetencia;
        }

        public void setVueltasRestantes(short vueltasRestantes)
        {
            this.vueltasRestantes = vueltasRestantes;
        }

        public short getVueltasRestantes()
        {
            return this.vueltasRestantes;
        }

        public static bool operator ==(AutoF1 a1, AutoF1 a2) 
        {
            return (a1.numero == a2.numero && a1.escuderia == a2.escuderia);
        }

        public static bool operator !=(AutoF1 a1, AutoF1 a2)
        {
            return !(a1 == a2);
        }



    }
}
