using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie24
{
    class Program
    {
        static void Main(string[] args)
        {
            double force, g, mass1 = double.Parse(Console.ReadLine()), mass2 = double.Parse(Console.ReadLine()), dist = double.Parse(Console.ReadLine());
            g = 9.8067;
            if (mass1 <=0 || mass2 <= 0)
            {
                Console.WriteLine("Масса должна быть положительной");
                return;
            }
            if (dist <=0)
            {
                Console.WriteLine("Дистанция должна быть неотрицательной");
            }
            else
            {
                force = g * mass1 * mass2 / Math.Pow(dist, 2);
                Console.WriteLine("{0:F4}",force);
            }
        }
    }
}
