using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie38
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                if (a%2 != 0)
                {
                    Console.Write(a);
                }
                while (a < (b -1))
                {
                    if (a % 2 == 0)
                    {
                        Console.Write(a + 1);
                    }
                    else
                    {
                        Console.Write(",");
                    }
                    a++;
                }
                if (b%2 != 0)
                {
                    Console.Write(b);
                }
                else
                {
                    Console.Write("");
                }
            }
            else
            {
                if (a % 2 != 0)
                {
                    Console.Write(a);
                }
                while ((b + 1) < a)
                {
                    if (a % 2 == 0)
                    {
                        Console.Write(a - 1);
                    }
                    else
                    {
                        Console.Write(",");
                    }
                    a--;                   
                }
                if (b % 2 != 0)
                {
                    Console.Write(b);
                }                
            }
        }
    }
}
