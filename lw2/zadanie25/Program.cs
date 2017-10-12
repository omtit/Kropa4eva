using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie25
{
    class Program
    {
        static void Main(string[] args)
        {
            double koren, res, a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), aInGrad = double.Parse(Console.ReadLine());
            koren = Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(aInGrad * Math.PI / 180);
            if (koren < 0)
            {
                Console.WriteLine("Подкоренное выражение отрицательно");
            }
            else
            {
                res = Math.Sqrt(koren);
                Console.WriteLine("{0:F4}", res);
            }
          
        }
    }
}
