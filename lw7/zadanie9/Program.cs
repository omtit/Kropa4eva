using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            string b,a1 = "U",a2 = "s",a = Console.ReadLine();            
            b = a.Substring(0, 1);
            if (b.Contains(a1))
            {
                b = a.ToUpper();
                for (int i = 0; i < b.Length; i++)
                {                   
                    Console.Write(b[i]);                   
                }
                return;
            }
            Console.WriteLine();
            if (b.Contains(a2))
            {
                b = a.ToLower();
                for (int i = 0; i < b.Length; i++)
                {
                    Console.Write(b[i]);
                }
            }
            Console.WriteLine();
        }
    }
}
