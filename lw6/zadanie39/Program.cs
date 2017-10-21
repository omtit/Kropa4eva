using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie39
{
    class Program
    {
        static void Main(string[] args)
        {
            double q1,p1,a, p = double.Parse(Console.ReadLine()), q = double.Parse(Console.ReadLine());
            a = (p + q) / 2; q1 = q; p1 = p;
            if (p < q)
            {
                while (p < a)
                {
                    Console.Write(p +"<");
                    p++;
                }
                while (a <= (q-1))
                {
                    Console.Write(p+">");
                    q--;
                    p++;
                }
                Console.WriteLine(q1);
            }
            else
            {
                while (q < a)
                {
                    Console.Write(q + "<");
                    q++;
                }
                while (a <= (p-1))
                {
                    Console.Write(q+">");
                    p--;
                    q++;
                }
                Console.WriteLine(p1);
            }

        }
    }
}
