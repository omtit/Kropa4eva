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
            double a, t = double.Parse(Console.ReadLine());            
            if (t < 0 || t > 59)
            {
                Console.WriteLine("Значение T должно быть в интервале [0, 59]");                
            }
            else
            {
                a = t % 5;
                if (a >= 0 && a <= 3)
                {
                    Console.WriteLine("Зеленый");
                }
                else
                {
                    Console.WriteLine("Красный");
                }
            }
        }
    }
}
