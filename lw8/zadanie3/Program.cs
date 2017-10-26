using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            String[] a = str.Split(' ');
            int i = 0;
            int k = a.Length;
            while (i < k)
            {
                Console.Write(a[k-1] + " ");
                k--;
            }
        }
    }
}
