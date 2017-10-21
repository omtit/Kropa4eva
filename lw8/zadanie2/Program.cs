using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = Console.ReadLine();
            String[] a = str.Split(' ');
            int i = 0;
            while (i < a.Length)
            {
                Console.WriteLine(a[i] +" "+ i);
                i++;
            }
        }
    }
}
