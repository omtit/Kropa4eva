using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie27
{
    class Program
    {
        static void Main(string[] args)
        {
            double res, x = double.Parse(Console.ReadLine());
            res = Math.Sqrt(1 - Math.Pow(Math.Sin(x * Math.PI / 180), 2));
            Console.WriteLine("{0:F4}",res);
        }
    }
}
