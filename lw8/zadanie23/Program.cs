using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie23
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
            int[] a2 = new int[a1.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = int.Parse(a1[i]);
            }
            int k = int.Parse(Console.ReadLine());
            int a = 0;
            for (int i = 0; i < a2.Length; i++)
            {
                if (a2[i] == k)
                {
                    a++;
                }
            }
            Console.WriteLine(a);
        }
    }
}
