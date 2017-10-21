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
            int sum = 0,a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            if (a > b)
            {
              while (b <= a)
                {
                    sum += a;
                    a--;
                }
            }
            else
            {
                while (a <= b)
                {
                    sum += a;
                    a++;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
