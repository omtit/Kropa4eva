using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine()), z = double.Parse(Console.ReadLine());
            if (x > y)
            {
                a = x;
            }
            else
            {
                a = y;
            }
            if (a > z)
            {
                Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(z);
            }
        }
    }
}
