using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie20
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            if (y >= -2 && y <= 1.5 )
            {
                Console.WriteLine("Точка принадлежит области");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит области");
            }
        }
    }
}
