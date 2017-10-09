using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie30
{
    class Program
    {
        static void Main(string[] args)
        {
            double res, aInGrad = double.Parse(Console.ReadLine()), bInGrad = double.Parse(Console.ReadLine());
            res = Math.Sin(Math.PI * aInGrad / 180) * Math.Cos(Math.PI * bInGrad / 180) + Math.Cos(Math.PI * aInGrad / 180) * Math.Sin(Math.PI * bInGrad / 180);
            Console.WriteLine("{0:F4}",res);
        }
    }
}
