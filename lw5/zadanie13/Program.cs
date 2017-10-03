using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int z = int.Parse(Console.ReadLine());
            if (x == y || y == z || x == z)
            {
                Console.WriteLine("Среди чисел есть равные");
            }
            else
            {
                Console.WriteLine("Числа не равны друг другу");
            }
        }
    }
}
