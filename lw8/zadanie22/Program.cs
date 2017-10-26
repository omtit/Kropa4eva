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
            String s1 = Console.ReadLine();
            if (String.IsNullOrEmpty(s1))
            {
                Console.WriteLine();
                return;
            }
            String[] a1 = s1.Split(' ');
            int[] b1 = new int[a1.Length];
            for (int i=0; i < a1.Length; i++)
            {
                b1[i] = int.Parse(a1[i]);
            }
        }
    }
}
