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
            
            int n = 0 ,a = int.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            if (a < 0)
            {
                Console.WriteLine("Значение A должно быть неотрицательным");
            }
            else
            {
                Console.Write("\"");
                while (n < a)
                {
                    Console.Write(b);
                    n = n + 1;
                }
                Console.Write("\"");
            }

        }
    }
}
