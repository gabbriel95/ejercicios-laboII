using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Biblioteca
{
    public class PuestoDeAtencion
    {
        public enum EPuesto
        {
            Caja1, Caja2
        }

        private static int numeroActual;
        private EPuesto puesto;

        public static int NumeroActual 
        { 
            get 
            { 
                return ++PuestoDeAtencion.numeroActual; 
            }
        }
        static PuestoDeAtencion()
        {
            PuestoDeAtencion.numeroActual = 0;
        }

        public PuestoDeAtencion(EPuesto puesto) 
        {
            this.puesto = puesto;
        }

        public bool Atender(Cliente cliente) 
        {
            Thread.Sleep(2000);
            return true;
        }


    }
}
