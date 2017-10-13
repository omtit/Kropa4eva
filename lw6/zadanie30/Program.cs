using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie30
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int i = 1;
            if (w < 0 || w > 20)
            {
                Console.WriteLine("	Значение W должно быть в интервале [0, 20]");
            }
            else
            {
                while (i <= w)
                {
                    Console.Write("a");
                    i = i + 1;
                }
                Console.WriteLine();
                i = 1;
                while (i <= w)
                {
                    Console.Write("b");
                    i = i + 1;
                }
                Console.WriteLine();
                i = 1;
                while (i <= w)
                {
                    Console.Write("c");
                    i = i + 1;
                }
                Console.WriteLine();
                i = 1;
                while (i <= w)
                {
                    Console.Write("d");
                    i = i + 1;
                }
                Console.WriteLine();
                i = 1;
                while (i <= w)
                {
                    Console.Write("e");
                    i = i + 1;
                }
                Console.WriteLine();
                i = 1;
                while (i <= w)
                {
                    Console.Write("f");
                    i = i + 1;
                }
                Console.WriteLine();
                i = 1;
                while (i <= w)
                {
                    Console.Write("g");
                    i = i + 1;
                }
                Console.WriteLine();
                i = 1; 
                while (i <= w)
                {
                    Console.Write("h");
                    i = i + 1;
                }

            }
        }
    }
}
