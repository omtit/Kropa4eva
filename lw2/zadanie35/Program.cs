using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie35
{
    class Program
    {
        static void Main(string[] args)
        {
            double res, x1 = double.Parse(Console.ReadLine()), x2 = double.Parse(Console.ReadLine());
            res = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2));
            Console.WriteLine("{0:F4}", res);
        }
    }
}
