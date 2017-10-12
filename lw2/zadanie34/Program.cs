using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie34
{
    class Program
    {
        static void Main(string[] args)
        {
            double res,aInRad, bInRad, aInGrad = double.Parse(Console.ReadLine()), bInGrad = double.Parse(Console.ReadLine());
            aInRad = Math.PI * aInGrad / 180;
            bInRad = Math.PI * bInGrad / 180;
            res = 3 * Math.Sin(2*aInRad) * Math.Cos(3 * bInRad);
            Console.WriteLine("{0:F4}",res);
        }
    }
}
