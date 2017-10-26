using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie21
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
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            String[] a1 = s1.Split(' ');
            for (int i = 0; i < a1.Length; i++)
            {
                if (int.Parse(a1[i]) == x)
                {
                    Console.Write(y + " ");
                }
                else
                {
                    Console.Write(a1[i] + " ");
                }
            }
        }
    }
}
