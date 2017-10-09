using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie22
{
    class Program
    {
        static void Main(string[] args)
        {
            double g, res, mass = double.Parse(Console.ReadLine()), aInGrad = double.Parse(Console.ReadLine());
            g = 9.8067;
            if (mass <= 0)
            {
                Console.WriteLine("Масса должна быть положительной");
                return;
            }
            else
            {
                res = mass * g * Math.Cos(aInGrad * Math.PI / 180);
                Console.WriteLine("{0:F6}",res);
            }
        }
    }
}
