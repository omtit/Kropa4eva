using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie35
{
    class Program
    {
        static void Main(string[] args)
        {
            int w1, i = 0, j = 0, w = int.Parse(Console.ReadLine());
            w1 = w - 1;
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            if (w == 0)
            {
                return;
            }
            int h1,h = int.Parse(Console.ReadLine());
            h1 = h - 1;           
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            if (h == 0)
            {
                return;
            }
            else
            {
                Console.Write(" ");                
                    while (i <= w1)
                    {
                        Console.Write(i);
                        i++;
                    }
                    i = 0;
                    Console.WriteLine();
                while (j <= h1)
                {
                    Console.Write(j);
                    while (i <= w1)
                    {
                        Console.Write(".");
                        i++;
                    }
                    Console.WriteLine("|");
                    i = 0;
                    j++;
                }
                Console.Write(" ");
                while (i <= w1)
                {
                    Console.Write("-");
                    i++;
                }
            }
        }
    }
}
