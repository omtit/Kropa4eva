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
            double s, speed1 = double.Parse(Console.ReadLine()), speed2 = double.Parse(Console.ReadLine());
            if (speed1<0)
            {
                Console.WriteLine("Значение speed1 должно быть неотрицательным");
                return;
            }
            if (speed2<0)
            {
                Console.WriteLine("Значение speed2 должно быть неотрицательным");
                return;
            }
            s = speed1 * 1000 / 3600;
            if (s > speed2)
            {
                Console.WriteLine("{1:F2} м/c меньше {0:F2} км/ч", speed1, speed2);
            }
            else
            {
                Console.WriteLine("{0:F2} км/ч меньше {1:F2} м/с",speed1,speed2);
            }
        }
    }
}
