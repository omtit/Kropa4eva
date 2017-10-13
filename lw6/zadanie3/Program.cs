using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                Console.WriteLine("Значение A должно быть не больше значения B");
            }
            else
            {
                while (a <= b)
                {
                    Console.WriteLine(a);
                    a = a + 1;
                }
            }
        }
    }
}
