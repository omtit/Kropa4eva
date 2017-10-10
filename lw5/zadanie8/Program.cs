using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");
                return;
            }
            double d, b = double.Parse(Console.ReadLine()), c = double.Parse(Console.ReadLine());
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d == 0)
            {
                Console.WriteLine("Уравнение "+a+"x^2 + "+b+"x + "+c+"  = 0 имеет один корень.");
                return;
            }
            if (d < 0)
            {
                Console.WriteLine("Вещественных корней уравнения " + a + "x^2 + " + b + "x + " + c+" = 0 нет.");
            }
            else
            {
                Console.WriteLine("У уравнения " + a + "x^2 + " + b + "x + " + c+" = 0 два вещественных.");
            }

        }
    }
}
