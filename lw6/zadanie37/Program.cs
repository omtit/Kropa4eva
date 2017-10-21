using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie37
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "", d = "+", s = "#";
            int i = 1, j = 1;
            int w = int.Parse(Console.ReadLine());
            if (w<0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            int h = int.Parse(Console.ReadLine());
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
                return;
            }
            if (h == 0 || w == 0)
            {
                return;
            }
            else
            {
                while (j <= h)
                {
                    while (i <= w)
                    {
                        Console.Write(d);
                        i++;
                    }
                    w--;
                    i = 1;
                    Console.Write(a);
                    Console.WriteLine();
                    a = a + s;
                    j++;
                }
            }
        }
    }
}
