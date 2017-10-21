using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            int e,i = 0, m = int.Parse(Console.ReadLine());
            String str = Console.ReadLine();
            String[] a = str.Split(' ');
            int[] b = new int[a.Length];
            while (i < a.Length)
            {
                b[i] = m * int.Parse(a[i]);
                Console.Write(b[i] + " ");
                i++;
            }
        }
    }
}
