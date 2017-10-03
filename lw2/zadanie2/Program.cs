using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            String edge;
            edge = Console.ReadLine();
            int a,area;
            a = int.Parse(edge);
            if (a <= 0)
            {
                Console.WriteLine("Значение edge должно быть положительным");
                return;
            }
            area = a * a * 6;
           
            Console.WriteLine(area);
                        
        }
    }
}
