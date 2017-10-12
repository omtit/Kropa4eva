using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie26
{
    class Program
    {
        static void Main(string[] args)
        {
            double res, a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), c = double.Parse(Console.ReadLine()), d = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Значение a должно быть не равно нулю");
                return;
            }
            if (d == 0)
            {
                Console.WriteLine("Значение d должно быть не равно нулю");                
            }
            else
            {
                res = (a * d + b * c) / (a * d);
                Console.WriteLine("{0:F4}",res);
            }
        }
    }
}
