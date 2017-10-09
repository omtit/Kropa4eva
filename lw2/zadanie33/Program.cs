using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie33
{
    class Program
    {
        static void Main(string[] args)
        {
            double res, r, x = double.Parse(Console.ReadLine());
            r = 6350;
            if (x < 0)
            {
                Console.WriteLine("Высота над уровнем Земли должна быть неотрицательна");
            }
            else
            {
                res = Math.Sqrt(Math.Pow(r + x, 2) - Math.Pow(r, 2));
                Console.WriteLine("{0:F4}",res);
            }
            
        }
    }
}
