using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar() 
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad) 
        {
            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizacion) : this(cantidad) 
        {
            Dolar.cotzRespectoDolar = cotizacion;
        }

        public double GetCantidad() 
        {
            return this.cantidad;
        }

        public static double GetCotizacion() 
        {
            return Dolar.cotzRespectoDolar;
        }

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad() * Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
        }

        public static implicit operator Dolar(double d) 
        {
            return  new Dolar(d);
        }

        //Generamos los Comparadores y sobrecargamos los operadores aritmeticos

        public static bool operator == (Dolar d1, Dolar d2) 
        {
            return (d1.GetCantidad() == d2.GetCantidad());
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1==d2);
        }

        public static bool operator ==(Dolar d, Euro e) 
        {
            return (d.GetCantidad() == ((Dolar)e).GetCantidad());
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Pesos p) 
        {
            return (d.GetCantidad() == ((Dolar)p).GetCantidad());
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d==p);
        }

        public static Dolar operator -(Dolar d, Euro e) 
        {
            return new Dolar((d.GetCantidad() - ((Dolar)e).GetCantidad()));
        }

        public static Dolar operator -(Dolar d, Pesos e)
        {
            return new Dolar((d.GetCantidad() - ((Dolar)e).GetCantidad()));
        }
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar((d.GetCantidad() + ((Dolar)e).GetCantidad()));
        }

        public static Dolar operator +(Dolar d, Pesos e)
        {
            return new Dolar((d.GetCantidad() + ((Dolar)e).GetCantidad()));
        }
    }
}
