using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            double a,b,c,x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine()), z = double.Parse(Console.ReadLine());
            if (x > 0)
            {
                a = Math.Pow(x, 2);
            }
            else
            {
                a = x;
            }
            if (y > 0)
            {
                b = Math.Pow(y, 2);           
            }
            else
            {
                b = y;
            }
            if (z > 0)
            {
                c = Math.Pow(z, 2);
            }
            else
            {
                c = z;
            }
            Console.WriteLine(a +"; "+b+"; "+c);
        }
    }
}
