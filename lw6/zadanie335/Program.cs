using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie335
{
    class Program
    {
        static void Main(string[] args)
        {
            String a,s = Console.ReadLine();
            a = s;
            int i = 1, h = int.Parse(Console.ReadLine());
            if (h < 0)
            {
                Console.WriteLine("Значение H должно быть неотрицательно");
            }
            else
            {
                while (i <= h)
                {
                    Console.WriteLine(s);
                    s = s + a;
                    i++;
                }
            }
        }
    }
}
