using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            double Sc = double.Parse(Console.ReadLine());
            if (Sc < 0 || Sc == 0)
            {
                Console.WriteLine("Площадь круга должна быть положительной");
                return;
            }
            double Ss = double.Parse(Console.ReadLine());
            if (Ss<0 || Ss == 0)
            {
                Console.WriteLine("Площадь квадрата должна быть положительной");
                return;
            }
            double radius, edge,d;
            radius = Math.Sqrt(Sc / Math.PI);
            edge = Math.Sqrt(Ss);
            d = 2 * radius;
            if (d < edge || d == edge)
            {
                Console.WriteLine("Круг уместится в квадрате");
            }
            else
            {
                Console.WriteLine("Круг не поместится в квадрате");
            }
        }
    }
}
