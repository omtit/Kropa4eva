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
            string a = Console.ReadLine();
            string b = "\"";
            string d = "[";
            string e = "]";
            int p = 0;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                string c = a.Substring(i, 1);
                if (c == d || c == e)
                {
                    Console.Write("\\" + c);
                }
                else
                {
                    if (c == b)
                    {
                        if (p % 2 == 0)
                        {
                            Console.Write("[");
                        }
                        else
                        {
                            Console.Write("]");
                        }
                        p++;
                    }
                    else
                    {
                        Console.Write(c);
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
