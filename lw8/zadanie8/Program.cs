using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            String s = Console.ReadLine();
            String[] s1 = s.Split(' ');           
            for (int i = 0; i < s1.Length; i++)
            {                
                Console.Write(s1[s1.Length - i - 1] + " ");                
            }
        }
    }
}
