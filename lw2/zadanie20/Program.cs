using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie20
{
    class Program
    {
        static void Main(string[] args)
        {
            double G,mass, velocity, height, Ek,Ep;
            G = 9.8067;
            mass = double.Parse(Console.ReadLine());
            if (mass <= 0)
            {
                Console.WriteLine("Значение mass должно быть положительным");
                return;
            }
            velocity = double.Parse(Console.ReadLine());
            if (velocity <= 0)
            {
                Console.WriteLine("Значение velocity должно быть положительным");
                return;
            }
            height = double.Parse(Console.ReadLine());
            if (height <0)
            {
                Console.WriteLine("Значение height должно быть неотрицательным");
            }
            else
            {
                Ek = mass * Math.Pow(velocity, 2) / 2;
                Ep = mass * G * height;
                Console.WriteLine("Кинетическая энергия составляет: {0:F4} Дж\nПотенциальная энергия составляет: {1:F4} Дж", Ek,Ep);
            }

        }
    }
}
