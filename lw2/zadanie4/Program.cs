using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            double circumference,a = double.Parse(Console.ReadLine()); 
            if (a <= 0)
            {
                Console.WriteLine("Радиус должен быть положительным");
                return;
            }
            circumference = 2*Math.PI*a;

            Console.WriteLine("{0:F4}", circumference);
        }
    }
}
