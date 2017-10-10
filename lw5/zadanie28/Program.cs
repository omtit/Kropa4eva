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
            double a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Значение a должно быть неотрицательным");
                return;
            }
            double b = double.Parse(Console.ReadLine());
            if (b <= 0)
            {
                Console.WriteLine("Значение b должно быть неотрицательным");
                return;
            }
            double c = double.Parse(Console.ReadLine());
            if (c <= 0)
            {
                Console.WriteLine("Значение c должно быть неотрицательным");
                return;
            }
            double d = double.Parse(Console.ReadLine());
            if (d <= 0)
            {
                Console.WriteLine("Значение d должно быть неотрицательным");
                return;
            }
            if (a <= c && a <= d && b <= c && b <= d)
            {
                Console.WriteLine("Размещение возможно");
            }
            else
            {
                Console.WriteLine("Размещение невозможно");
            }
        }
    }
}
