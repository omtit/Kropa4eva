using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            String grad;
            grad = Console.ReadLine();
            double a, rad;
            a = double.Parse(grad);
            rad = a * Math.PI / 180;
            Console.WriteLine("{0:F4}",rad);
        }
    }
}
