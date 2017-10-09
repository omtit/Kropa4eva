using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie31
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, x = double.Parse(Console.ReadLine());
            y = 7 * Math.Pow(x, 2) - 3 * x + 6;
            Console.WriteLine(y);
        }
    }
}
