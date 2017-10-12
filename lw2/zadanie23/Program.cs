using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie23
{
    class Program
    {
        static void Main(string[] args)
        {
            double disc, a = double.Parse(Console.ReadLine()), b = double.Parse(Console.ReadLine()), c = double.Parse(Console.ReadLine());
            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Данное уравнение не является квадратным");            }
            else
            {
                disc = Math.Pow(b, 2) - 4 * a * c;
                Console.WriteLine("{0:F4}",disc);
            }
        }
    }
}
