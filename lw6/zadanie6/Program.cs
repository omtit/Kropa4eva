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
            int a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            if (a < b)
            {
                while (a <= b)
                {
                    Console.Write(a +" ");
                    a++;
                }
            }
            else
            {
                while (a >= b)
                {
                    Console.Write(b+" ");
                    b++;
                }
            }
        }
    }
}
