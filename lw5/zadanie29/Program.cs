using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie29
{
    class Program
    {
        static void Main(string[] args)
        {
            double Xt = double.Parse(Console.ReadLine());
            if (Xt <= 0)
            {
                Console.WriteLine("Координата x должна быть неотрицательной");
                return;
            }
            double Yt = double.Parse(Console.ReadLine());
            if (Yt <= 0)
            {
                Console.WriteLine("Координата y должна быть неотрицательной");
                return;
            }
            if (Xt >= 100 && Xt <= 190 && Yt >= 100 && Yt <= 170)
            {
                Console.WriteLine("Точка внутри");
            }
            else
            {
                Console.WriteLine("Точка снаружи");
            }
        }
    }
}
