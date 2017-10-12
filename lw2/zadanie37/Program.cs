using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie37
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, temp, v1 = double.Parse(Console.ReadLine()), t1 = double.Parse(Console.ReadLine()), v2 = double.Parse(Console.ReadLine()), t2 = double.Parse(Console.ReadLine());
            if (v1 <= 0 || v2 <= 0)
            {
                Console.WriteLine("Объем должен быть неотрицательным");
            }
            else
            {
                volume = v1 + v2;
                temp = (t1 * v1 + t2 * v2) / (v1 + v2);
                Console.WriteLine("Объем - {0:F0}, Температура - {1:F4}", volume, temp);
            }
            }
        }
    }
