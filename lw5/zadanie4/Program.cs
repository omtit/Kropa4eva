using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, a = double.Parse(Console.ReadLine());
            if (a < 0)
            {
                A = a*-1;
            }
            else
            {
                A = a;
            }
            Console.WriteLine("{0:F4}", A);
        }
    }
}
