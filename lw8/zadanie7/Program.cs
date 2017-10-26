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
            int i = 0;
            while (i < s1.Length)
            {
                int j = s1.Length - i - 1;
                Console.Write(s1[j] + " ");
                i++;
            }
        }
    }
}
