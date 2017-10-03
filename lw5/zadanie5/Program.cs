using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            double distanceInKm = double.Parse(Console.ReadLine());
            double distanceInFeet = double.Parse(Console.ReadLine());
            if (distanceInKm<0)
            {
                Console.WriteLine("Значение distanceInKm должно быть неотрицательным");
                return;
            }
            if (distanceInFeet < 0)
            {
                Console.WriteLine("Значение distanceInFeet должно быть неотрицательным");
                return;
            }
            if (distanceInKm*1000 > distanceInFeet*0.305)
            {
                Console.WriteLine("Расстояние в футах меньше");
            }
            else
            {
                Console.WriteLine("Расстояние в километрах меньше");
            }

        }
    }
}
