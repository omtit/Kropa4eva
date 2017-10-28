using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 13, 17, 19, 10, 12, 14, 15, 16, 18, 20 };
            int b = int.Parse(Console.ReadLine());
            int i = 0;
            while (i < a.Length)
            {
                if (a[i] == b)
                {
                    Console.WriteLine(a[i] + "+");
                }
                else
                {
                    Console.WriteLine(a[i]);
                }
                i++;
            }
        }
    }
}
