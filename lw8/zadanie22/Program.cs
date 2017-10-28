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
            int[] a2 = new int[a1.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = int.Parse(a1[i]);
            }
            int k = 0;
            for (int i = 0; i < a2.Length; i++)
            {
                for (int j = 0; j < a2.Length - 1; j++)
                {
                    if (a2[j] > a2[j + 1])
                    {
                        k = a2[j + 1];
                        a2[j + 1] = a2[j];
                        a2[j] = k;
                    }
                }
            }
            for (int i = 0; i < a2.Length; i++)
            {
                Console.Write(a2[i] + " ");
            }
        }
    }
}
