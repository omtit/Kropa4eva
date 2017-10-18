using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            long x = 1,a = long.Parse(Console.ReadLine()), b = long.Parse(Console.ReadLine());
          
            if (a < b)
            {
                while (a <= b)
                {
                    x = x * a;
                    a++;
                }
            }
            else
            {
                while (b <= a)
                {
                    x = x * b;
                    b++;
                }
            }
            Console.WriteLine(x);
        }
    }
}
