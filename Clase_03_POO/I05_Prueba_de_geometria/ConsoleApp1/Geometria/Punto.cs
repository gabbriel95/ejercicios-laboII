using System;

namespace Geometria
{
    public class Punto
    {
        private int x;
        private int y;

        public Punto(int y, int x) 
        { 
            this.y = y;
            this.x = x; 
        }

        public int GetX() 
        {
            return this.x;        
        }
        public int GetY()
        {
            return this.y;
        }
    }

    public class Rectangulo 
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3) 
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            
        }

      
        public float GetArea()
        {
            if (this.area == 0) 
            {
                int baseRectangulo = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
                int alt = Math.Abs(vertice1.GetY() - vertice3.GetY());
                return this.area = (float)baseRectangulo * alt;
            
            }

            return this.area;
        }

        public float GetPerimetro()
        {
            if (this.perimetro == 0) 
            { 
                int baseRectangulo = Math.Abs(vertice1.GetX() - vertice3.GetX());
                int alt = Math.Abs(vertice1.GetY() - vertice3.GetY());
                return this.perimetro = (float)((baseRectangulo + alt) * 2);
            
            }

            return this.perimetro;
        }

    }
}
