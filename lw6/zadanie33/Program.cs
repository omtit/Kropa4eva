using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie33
{
    class Program
    {
        static void Main(string[] args)
        {
            int w1, i=1 ,w = int.Parse(Console.ReadLine());
            w1 = w - 2;
            if (w < 0)
            {
                Console.WriteLine("Значение W должно быть неотрицательно");
            }
            else
            {
                Console.Write("+");
                while (i <= w1)
                {
                    Console.Write("-");
                    i++;
                }
                Console.WriteLine("+");
                i = 1;
                Console.Write("|");
                while (i <= w1)
                {
                    Console.Write(".");
                    i++;
                }
                Console.WriteLine("|");
                i = 1;
                Console.Write("+");
                while (i <= w1)
                {
                    Console.Write("-");
                    i++;
                }
                Console.WriteLine("+");
            }
        }
    }
}
