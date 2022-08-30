using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMM_Lab_S2
{
    public class Rectangulo
    {
        public Vertice v1 { get; set; }
        public Vertice v2 { get; set; }
        public Vertice v3 { get; set; }
        public Vertice v4 { get; set; }

        public double CalcularArea()
        {
            double lado = Math.Sqrt(Math.Pow(v1.x - v2.x,2) + Math.Pow(v1.y - v2.y,2));
            double altura = Math.Sqrt(Math.Pow(v2.x - v3.x, 2) + Math.Pow(v2.y - v3.y, 2));
            double area=lado*altura;
            return area;
        }

        public double CalcularPerimetro()
        {
            double lado = Math.Sqrt(Math.Pow(v1.x - v2.x, 2) + Math.Pow(v1.y - v2.y, 2));
            double altura = Math.Sqrt(Math.Pow(v2.x - v3.x, 2) + Math.Pow(v2.y - v3.y, 2));
            double perimetro = 2 * lado + 2 * altura; 
            return perimetro;
        }
    }
}
