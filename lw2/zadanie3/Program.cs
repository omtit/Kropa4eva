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
            String edge;
            edge = Console.ReadLine();
            int a, volume;
            double b, vol;
            a = int.Parse(edge);
            b = double.Parse(edge);
            if (a <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            volume = a * a * a;
            vol = Math.Pow(b, 3);
            Console.WriteLine(volume);
            Console.WriteLine("{0:F0}",vol);
        }
    }
}
