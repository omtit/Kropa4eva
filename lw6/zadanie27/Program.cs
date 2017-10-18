using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie27
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()), i = 1;
            if (x <= 0)
            {
                Console.WriteLine("Значение X должно быть положительным");
            }
            else
            {
                while (i <= x)
                {
                    if (x % i == 0)
                    {
                        Console.Write(i + " ");
                    }
                    i++;
                }
            }
        }
    }
}
