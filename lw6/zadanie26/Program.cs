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
            int x = 0, n = 100, m = 1000;
            while (n <= m)
            {
                if (n % 13 != 0)
                {
                    Console.Write(n+ " ");
                }
                else
                {
                    Console.Write(n+ "+ ");
                    x++;
                }
                n++;
            }
            Console.WriteLine();
            Console.WriteLine("Ответ:" + x);
        }
    }
}
