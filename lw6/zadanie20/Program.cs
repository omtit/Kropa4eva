using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie20
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), res=0;
            if (a > b)
            {
                while (b <= a)
                {
                    res += Math.Pow(a, 2);
                    a--;
                }
            }
            else
            {
                while (a <= b)
                {
                    res += Math.Pow(a, 2);
                    a++;
                }
            }
            Console.WriteLine(res);
        }
    }
}
