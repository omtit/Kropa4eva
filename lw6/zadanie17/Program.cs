using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie17
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            int a = int.Parse(Console.ReadLine());
            while (a != 0)
            {
                sum += a;
                count++;
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Сумма чисел: {0}, Количество чисел: {1}" , sum, count);
        }
    }
}
