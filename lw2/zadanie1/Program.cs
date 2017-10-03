using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            x = double.Parse(Console.ReadLine());
            double res;
            res = x + 7;
            Console.WriteLine("{0:F4}",res);

        }
    }
}
