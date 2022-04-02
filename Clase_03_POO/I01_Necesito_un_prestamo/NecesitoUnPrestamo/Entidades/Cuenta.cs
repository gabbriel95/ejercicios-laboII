using System;

namespace Entidades
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad) 
        {
        
            this.titular = titular;
            this.cantidad = cantidad;
        }


        public string GetTitular() 
        {
            return this.titular;
        }

        public decimal GetCantidad() 
        {
            return this.cantidad;
        }

        public string Mostrar() 
        {
            return $"Titular: {this.titular} \nCantidad: {this.cantidad}";
        }

        public void Ingresar(decimal value) 
        {
            if (value > 0) 
            {
                this.cantidad += value;
            }
        }

        public void Retirar(decimal value) 
        {
            if (value > 0) 
            {
                this.cantidad -= value; 
            }
        }


    }
}
