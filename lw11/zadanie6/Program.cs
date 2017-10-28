using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            Random rnd = new Random(13);
            for(int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next() % 899 + 100;
                a[i] = rnd.Next(100, 999);
            }
            Console.WriteLine(String.Join(",",a));
        }
    }
}
