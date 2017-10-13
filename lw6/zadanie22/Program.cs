using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int i = 1;
            while (i<=n)
            {
                if (i % 5 != 0)
                {
                    Console.Write("!");
                    i = i + 1;
                }
                else
                {
                    Console.Write("! ");
                    i = i + 1;
                }
            }

        }
    }
}
