using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            double area, length = double.Parse(Console.ReadLine()), heigth = double.Parse(Console.ReadLine());
            area = length * heigth / 2;
            Console.WriteLine("{0:F2}",area);

        }
    }
}
