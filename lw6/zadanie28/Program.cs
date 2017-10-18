using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie28
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = double.Parse(Console.ReadLine()), i = 1, a = 0;
            if (y <= 0)
            {
                Console.WriteLine("Значение Y должно быть положительным");
            }
            else
            {
                while (i <= y)
                {
                    if (y % i == 0)
                    {                       
                        a++;
                    }
                    i++;
                }
                if (a > 2)
                {
                    Console.WriteLine("Число не простое");
                }
                else
                {
                    Console.WriteLine("Число простое");
                }
            }

        }
    }
}
