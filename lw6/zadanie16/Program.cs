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
            double res = 0, n = double.Parse(Console.ReadLine()), i = 1;
            if (n <= 0)
            {
                Console.WriteLine("Значение n должно быть положительным");
                return;
            }
            else
            {
                while (i <= n)
                {
                    res += 1 / i;
                    i++;
                }
            }
            Console.WriteLine("{0:F4}",res);
        }
    }
}
