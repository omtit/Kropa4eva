using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());
            String[] s1 = s.Split(' ');
            String[] s2 = new String[s1.Length];
            int i = 0;            
            while (i < s1.Length)
            {
                if (k >= 0)
                {
                    int k1 = s1.Length - k % s1.Length;
                    s2[i] = s1[(i + k1)%s1.Length];
                    Console.Write(s2[i]+" ");
                }
                else
                {
                    int k1 =k % s1.Length + s1.Length;
                    s2[i] = s1[(i + k1)%s1.Length];
                    Console.Write(s2[i] + " ");
                }
                i++;
            }
            
        }
    }
}
