using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            double result, Ingrad = double.Parse(Console.ReadLine());
            result = 5*Math.Cos(Ingrad * Math.PI / 180);
            Console.WriteLine("{0:F4}",result);
        }
    }
}
