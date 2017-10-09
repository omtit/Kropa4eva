using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie19
{
    class Program
    {
        static void Main(string[] args)
        {
            double dist, speedat0 = double.Parse(Console.ReadLine()), time = double.Parse(Console.ReadLine()), acc = double.Parse(Console.ReadLine());
            if (speedat0 <0)
            {
                Console.WriteLine("Начальная скорость должнa быть неотрицательна");
                return;
            }
            if (time<=0)
            {
                Console.WriteLine("Время должно быть положительным");
            }
            else
            {
                dist = speedat0 * time + acc * Math.Pow(time, 2) / 2;
                Console.WriteLine("{0:F2}",dist);
            }

        }
    }
}
