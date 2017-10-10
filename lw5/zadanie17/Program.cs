using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie17
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            if (p == 0)
            {
                Console.WriteLine("Значение P должно быть не равно нулю");
                return;
            }
            double k,l;
            l = m / p;
            k = m % p;
            if (k == 0)
            {
                Console.WriteLine(l);
            }
            else
            {
                Console.WriteLine("m не делится нацело на p");
            }
        }
    }
}
