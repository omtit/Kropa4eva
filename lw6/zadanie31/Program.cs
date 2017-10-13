using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie31
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int i = 1;
            int j = 0;
            if (w < 0 || w > 20)
            {
                Console.WriteLine("	Значение W должно быть в интервале [0, 20]");
            }
            else
            {
                while (j <= 9)
                {
                    while (i <= w)
                    {
                        Console.Write(j);
                        i = i + 1;
                    }
                    j = j + 1;
                    Console.WriteLine();
                    i = 1;
                }
               }
                
        }
    }
}
