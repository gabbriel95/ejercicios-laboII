using System;

namespace LogicaNegocio
{
    public static class CalculadoraDeAreas
    {
        private static double area;

        public static double CalcularAreaCuadrado(double longitudLado) {

            area = Math.Pow(longitudLado, 2);

            return area;
        }

        public static double CalcularAreaTriangulo(double basse, double altura) {

            area = (basse * altura) / 2;

            return area;
        }

        public static double CalcularAreaCirculo(double radio) {

            area = Math.PI * Math.Pow(radio, 2);    

            return area;
        }

    }
}
