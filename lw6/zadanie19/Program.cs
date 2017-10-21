using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie19
{
    class Program
    {
        static void Main(string[] args)
        {

            double b = 83, c = 199, countleft = 0, countright = 0;
            double a = 0;
            while (a <= b || a >= c) 
            {
                a = double.Parse(Console.ReadLine());
                if (a <= b || a >= c)
                {
                    if (a >= c)
                    {
                        countright++;
                    }
                    if (a <= b)
                    {
                        countleft++;
                    }
                }

            }
            Console.WriteLine("Количество слева: {0}, Количество справа: {1}", countleft,countright);
        }
    }
}
