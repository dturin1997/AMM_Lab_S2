using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AMM_Lab_S2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("v4---------------v3");
            Console.WriteLine(" |               |");
            Console.WriteLine(" |               |");
            Console.WriteLine("v1---------------v2");

            Rectangulo rectangulo = new Rectangulo();

            rectangulo.v1 =new Vertice { x = 0, y = 2 };

            rectangulo.v2 = new Vertice { x = 6, y = 2 };

            rectangulo.v3 = new Vertice { x = 6, y = 6 };

            rectangulo.v4 = new Vertice { x = 0, y = 6 };

            Console.WriteLine("El Area del Rectangulo es : ");
            Console.WriteLine(rectangulo.CalcularArea());

            Console.WriteLine("El Perímetro del Rectangulo es : ");
            Console.WriteLine(rectangulo.CalcularPerimetro());

            Console.Read();
        }
    }
}
