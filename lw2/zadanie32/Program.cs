using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie32
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, a = double.Parse(Console.ReadLine());
            b = 12 * Math.Pow(a, 2) + 7 * a - 16;
            Console.WriteLine("{0:F4}",b);
        }
    }
}
