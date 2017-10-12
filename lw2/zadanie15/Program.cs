using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            double TempInF, TempInC = double.Parse(Console.ReadLine());
            if (TempInC < - 273.15)
            {
                Console.WriteLine("Температура должна быть выше абсолютного нуля");             
            }
            else
            {
                TempInF = TempInC * 1.8 + 32;
                Console.WriteLine("{0:F4}",TempInF);
            }
        }
    }
}
