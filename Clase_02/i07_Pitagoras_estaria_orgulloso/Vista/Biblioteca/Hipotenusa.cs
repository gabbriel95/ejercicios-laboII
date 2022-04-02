using System;

namespace Biblioteca
{
    public class Hipotenusa
    {
        public static float calcularHipotenusa(int alturaTriangulo, int baseTriangulo) 
        {
            float hipotenusa;
            int catetoA = (int)Math.Pow(alturaTriangulo, 2);
            int catetoB = (int)Math.Pow(baseTriangulo, 2);

            hipotenusa = (float)Math.Sqrt(catetoA + catetoB);

            return hipotenusa;
        }
    }
}
