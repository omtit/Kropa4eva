using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            double res, koren, x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            if (y<0)
            {
                Console.WriteLine("Значение y должно быть неотрицательным");
                return;
            }
            else
            {
                koren = x + Math.Sqrt(y);
            }
            if (koren <0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
            }
            else
            {
                res = -5 * Math.Sqrt(koren);
                Console.WriteLine("{0:F4}",res);
            }
        }
    }
}
