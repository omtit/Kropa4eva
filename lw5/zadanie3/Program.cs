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
            double K,k = double.Parse(Console.ReadLine());
            if (k <= 0)
            {
                K = Math.Pow(k, 2);             
            }
            else
            {
                K = Math.Sqrt(k);
            }
            Console.WriteLine("{0:F4}",K);
        }
    }
}
