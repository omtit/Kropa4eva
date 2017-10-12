using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie28
{
    class Program
    {
        static void Main(string[] args)
        {
            double res, koren, a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), c = double.Parse(Console.ReadLine()), x = double.Parse(Console.ReadLine());
            koren = a * Math.Pow(x, 2) + b * x + c;
            if (koren < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");
                return;
            }
            if (koren == 0)
            {
                Console.WriteLine("Знаменатель не может быть равен нулю");              
            }
            else
            {
                res = 1 / Math.Sqrt(koren);
                Console.WriteLine("{0:F4}",res);
            }
        }
    }
}
