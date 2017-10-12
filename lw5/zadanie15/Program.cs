using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Значение a должно быть неотрицательным");
                return;
            }
            double b = double.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Значение b должно быть неотрицательным");
                return;
            }
            double c = double.Parse(Console.ReadLine());
            if (c <= 0)
            {
                Console.WriteLine("Значение c должно быть неотрицательным");
                return;
            }
            if (a == b || b == c || a == c)
            {
                Console.WriteLine("Треугольник является равнобедренным.");
            }
            else
            {
                Console.WriteLine("Треугольник не является равнобедренным.");
            }
        }
    }
}
