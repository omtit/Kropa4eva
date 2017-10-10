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
            double a = double.Parse(Console.ReadLine());
            if (a < -10 || a > 100)
            {
                Console.WriteLine("Значение A должно быть в интервале [-10, 100]");
                return;
            }
            if (a == -8 || a == -7 || a == -6 || a == -2 || a == 0 || a == 2 || a == 6 || a == 7 || a == 8 || a == 22 || a == 26 || a == 27 || a == 28 || a == 32 || a == 36 || a == 37 || a == 38 || a == 40 || a == 42 || a == 46 || a == 47 || a == 48 || a == 52 || a == 56 || a == 58 || a == 57 || a == 62 || a == 66 || a == 67 || a == 68 || a == 72 || a == 78 || a == 76 || a == 77 || a == 82 || a == 86 || a == 87 || a == 88 || a == 92 || a == 97 || a == 96 || a == 98)
            {
                Console.WriteLine(a + "-ой");
                return;
            }
            if (a == -3 || a == 3 || a == 23 || a == 33 || a == 43 || a == 53 || a == 63 || a == 73 || a == 83 || a == 93)
            {
                Console.WriteLine(a + "-ий");
            }
            else
            {
                Console.WriteLine(a + "-ый");
            }
        }
    }
}
