using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie21
{
    class Program
    {
        static void Main(string[] args)
        {
            double res, r1 = double.Parse(Console.ReadLine()), r2 = double.Parse(Console.ReadLine());
            if (r1 == 0)
            {
                Console.WriteLine("Значение r1 должно быть не равно нулю");
                return;
            }
            if (r2 == 0)
            {
                Console.WriteLine("Значение r2 должно быть не равно нулю");           
            }
            else
            {
                res = 1 / r1 + 1 / r2;
                Console.WriteLine("{0:F4}",res);
            }
        }
    }
}
