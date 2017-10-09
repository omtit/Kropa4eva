using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie17
{
    class Program
    {
        static void Main(string[] args)
        {
            double time, dist = double.Parse(Console.ReadLine()), speed1 = double.Parse(Console.ReadLine()), speed2 = double.Parse(Console.ReadLine());
            if (dist < 0 || speed1 < 0 || speed2 < 0)
            {
                Console.WriteLine("Скорость и расстояние должны быть неотрицательны");
            }
            else
            {
                time = dist / (speed1 + speed2);
                Console.WriteLine("{0:F4}",time);
            }
        }
    }
}
