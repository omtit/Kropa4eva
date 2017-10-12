using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            double result, koren, x = double.Parse(Console.ReadLine());
            koren = 61 - x;
            if (koren < 0)
            {
                Console.WriteLine("Подкоренное выражение должно быть неотрицательным");              
            }
            else
            {
                result = 3 * Math.Sqrt(koren);
                Console.WriteLine("{0:F4}", result);
            }
        }
    }
}
