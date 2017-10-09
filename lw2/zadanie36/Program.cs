using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie36
{
    class Program
    {
        static void Main(string[] args)
        {
            double res, xa = double.Parse(Console.ReadLine()), ya = double.Parse(Console.ReadLine()), xb = double.Parse(Console.ReadLine()), yb = double.Parse(Console.ReadLine());
            res = Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
            Console.WriteLine("{0:F4}", res);
        }
    }
}
