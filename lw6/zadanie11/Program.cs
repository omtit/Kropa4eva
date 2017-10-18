using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
           int sum = 0, A = int.Parse(Console.ReadLine());
            if (A > 500 || A < -100)
            {
                Console.WriteLine("Значение A должно быть в интервале [-100, 500]");
            }
            else
            {
                while (A <= 500)
                {
                    sum += A;
                    A++;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
