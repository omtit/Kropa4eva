using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie227
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), sum = 0;
            if (a > b)
            {
                while (a >= b)
                {
                    if (a % 7 == 0)
                    {
                        sum += a;
                    }
                    a--;
                }
            }
            else
            {
                while (a <= b)
                {
                    if (a % 7 == 0)
                    {
                        sum += a;
                    }
                    a++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
