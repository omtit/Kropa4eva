using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zdanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            string xLnRad;
            xLnRad = Console.ReadLine();
            double a,b;
            a = double.Parse(xLnRad);
            b = Math.Sin(a * Math.PI / 180);
            Console.WriteLine("{0:F4}",b);
        }
    }
}
