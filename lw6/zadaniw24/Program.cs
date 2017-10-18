using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadaniw24
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int n = 30, m = 40;
            while (n <= m)
            {
                if (x == n)
                {
                    Console.WriteLine(x + "+");
                }
                else
                {
                    Console.WriteLine(n + "-");
                }
                n = n + 1;
            }
        }
    }
}
