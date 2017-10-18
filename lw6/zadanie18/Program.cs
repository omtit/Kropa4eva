using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie18
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            while (sum <= 1000)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;
                count++;
                
            }
            Console.WriteLine("Количество чисел:" + count);
        }
    }
    }

