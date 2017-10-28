using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie24
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
            int[] a3 = new int[a1.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = int.Parse(a1[i]);
            }

            for (int i = 0; i < a2.Length; i++)
            {
                int amount = 0;
                int s = a2[i];
                for (int j = 0; j < a2.Length; j++)
                {
                    if (s == a2[j])
                    {
                        amount++;
                    }
                }
                a3[i] = amount;
                Console.Write(a3[i] + " ");
            }
        }
    }
}
