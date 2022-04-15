using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<AutoF1> competidores;

        private Competencia() 
        {
            this.competidores = new List<AutoF1>();
        }

        public Competencia(short cantidadVueltas, short cantidadCompetidores) : this()
        {
            this.cantidadVueltas = cantidadVueltas;
            this.cantidadCompetidores = cantidadCompetidores;
        }


        public static bool operator +(Competencia c, AutoF1 a) 
        {
            if (c.competidores.Count <= c.cantidadCompetidores && c != a) 
            {
                c.competidores.Add(a);
                a.setEnCompetencia(true);
                a.setVueltasRestantes(c.cantidadVueltas);
                Random num = new Random();
                a.setCantidadCombustible((short)num.Next(15, 100));
                
                return true;
            }

            return false;
        }

        public static bool operator -(Competencia c, AutoF1 a) 
        {
            if (c == a) 
            {
                c.competidores.Remove(a);
                return true;
            }

            return false;
        }

        public static bool operator ==(Competencia c, AutoF1 a)
        {
       
                foreach (AutoF1 auto in c.competidores)
                {
                    if (auto == a) 
                    {
                        return true;
                    }
                }
            

            return false;
        }

        public static bool operator !=(Competencia c, AutoF1 a)
        {

            return !(c==a);
        }
    }
}
