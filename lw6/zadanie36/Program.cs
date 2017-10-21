using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie36
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            String c ="",s = ".";           
            if (a > b)
            {
                while (b <= a)
                {
                    if (b%2 != 0)
                    {
                        Console.Write(c);
                        Console.WriteLine(b);
                        c = c + s;
                    }                    
                    b++;
                }
            }
            else
            {
                while (a <= b)
                {
                    if (a % 2 != 0)
                    {
                        Console.Write(c);
                        Console.WriteLine(a);
                        c = c + s;
                    }
                    a++;
                }
            }
        }
    }
}
