using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie32
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            double i=1, j=1, w = double.Parse(Console.ReadLine());
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
                return;
            }
            double h = double.Parse(Console.ReadLine());
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");                
            }
            else
            {
                while (j <= h)
                {
                    while (i <= w)
                    {
                        Console.Write(s);
                        i++;
                    }
                    i = 1;
                    Console.WriteLine();
                    j++;
                }

            }

        }
    }
}
