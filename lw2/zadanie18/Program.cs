using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie18
{
    class Program
    {
        static void Main(string[] args)
        {
            int res, x1 = int.Parse(Console.ReadLine()), x2 = int.Parse(Console.ReadLine()), x3 = int.Parse(Console.ReadLine());
            res = x1 * x2 + x1 * x3 + x2 * x3;
            Console.WriteLine(res);
        }
    }
}
