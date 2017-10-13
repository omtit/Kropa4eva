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
            int x = int.Parse(Console.ReadLine());
            int n = 10, m = 20;
            while (n <= m)
            {
                if (x == n)
                {
                    Console.WriteLine(x + "+");
                    n = n + 1;
                }
                else
                {
                    Console.WriteLine(n);
                    n = n + 1;
                }
            }
        }
    }
}
