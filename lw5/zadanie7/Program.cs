using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            double s1, s2; 
            double radius = double.Parse(Console.ReadLine());
            if (radius < 0)
            {
                Console.WriteLine("Радиус должен быть положительным");
                return;
            }
            double edge = double.Parse(Console.ReadLine());
            if (edge < 0)
            {
                Console.WriteLine("Сторона квадрата должнам быть положительной");
                return;
            }
            s1 = Math.Pow(edge, 2);
            s2 = Math.Pow(radius, 2) * Math.PI;
            if (s1 == s2)
            {
                Console.WriteLine("Площади равны");
                return;
            }
            if (s1 > s2)
            {
                Console.WriteLine("Площадь квардрата {0:F4} больше площади круга {1:F4}", s1, s2);
            }
            else
            {
                Console.WriteLine("Площадь круга {1:F4} больше площади квадрата {0:F4} км/ч", s1, s2);
            }
        }
    }
}
