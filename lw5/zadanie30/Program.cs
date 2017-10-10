using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie30
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xt = double.Parse(Console.ReadLine());
            if (Xt < 0)
            {
                Console.WriteLine("Координата x должна быть неотрицательной");
                return;
            }
            double Yt = double.Parse(Console.ReadLine());
            if (Yt < 0)
            {
                Console.WriteLine("Координата y должна быть неотрицательной");
                return;
            }
            double Xp1 = double.Parse(Console.ReadLine());
            if (Xp1 < 0)
            {
                Console.WriteLine("Координата x должна быть неотрицательной");
                return;
            }
            double Yp1 = double.Parse(Console.ReadLine());
            if (Yp1 < 0)
            {
                Console.WriteLine("Координата y должна быть неотрицательной");
                return;
            }
            double Xp2 = double.Parse(Console.ReadLine());
            if (Xp2 < 0)
            {
                Console.WriteLine("Координата x должна быть неотрицательной");
                return;
            }
            double Yp2 = double.Parse(Console.ReadLine());
            if (Yp2 < 0)
            {
                Console.WriteLine("Координата y должна быть неотрицательной");
                return;
            }
            double a, b;
            a = (Xt - Xp1) * (Xp2 - Xp1);
            b = (Yt - Yp1) * (Yp2 - Yp1);
            if (a == b)
            {
                Console.WriteLine("Точка принадлежит прямой");
            }
            else
            {
                Console.WriteLine("Точка не принадлежит прямой");
            }
        }
    }
}
