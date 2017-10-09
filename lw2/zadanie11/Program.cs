using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x = double.Parse(Console.ReadLine());
            if (x >= 0)
            {
                y = Math.Sqrt(x);
                Console.WriteLine("{0:F4}", y);
            }
            else
            {
                Console.WriteLine("Значение Х должно быть положительным");
            }
            

        }
    }
}
