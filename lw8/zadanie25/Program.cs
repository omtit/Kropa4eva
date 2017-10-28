using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie25
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
            int am1 = 0, am2 = 0;
            for (int i = 0; i < a2.Length; i++)
            {
                int s = a2[i];
                for (int j = 0; j < a2.Length - 1; j++)
                {
                    if (s == a2[j + 1])
                    {
                        am1++;
                    }
                }
                if (am1 > 0)
                {
                    am2++;
                }
            }
            int[] a3 = new int[am2];
            for (int i = 0; i < a2.Length; i++)
            {
                int s = a2[i];
                for (int j = 1; j < a2.Length; j++)
                {
                    if (s == a2[j])
                    {                        
                        
                    }
                }
            }
        }
    }
}
