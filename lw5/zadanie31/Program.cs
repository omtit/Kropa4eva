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
            double A1 = double.Parse(Console.ReadLine()), B1 = double.Parse(Console.ReadLine()), A2 = double.Parse(Console.ReadLine()), B2 = double.Parse(Console.ReadLine());
            if (A1 > B1 || A2 > B2)
            {
                Console.WriteLine("Значение A должно быть меньше значения B");
                return;
            }
            double A3, B3;
            if ((A1 < A2 && B1 < A2) || (A1 > B2 && B1 > B2))
            {
                Console.WriteLine("Интервалы не пересекаются");
            }
            else
            {
                if (A1 < A2)
                {
                    A3 = A2;
                }
                else
                {
                    A3 = A1;
                }
                if (B1 < B2)
                {
                    B3 = B1;
                }
                else
                {
                    B3 = B2;
                }
                Console.WriteLine("Интервалы пересекаюся ("+A3+";"+B3+")");
            }




        }
    }
}
