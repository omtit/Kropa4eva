using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, a = double.Parse(Console.ReadLine());
            if (a <= 0)
            {
                Console.WriteLine("Значение radius должно быть положительным");
                return;
            }
            volume = 4 * Math.PI * Math.Pow(a,3)/3;

            Console.WriteLine("{0:F4}", volume);
        }
    }
}
