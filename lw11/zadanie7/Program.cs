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
            int[] a = new int[10];
            Random rnd = new Random();
            for (int i = 0; i < a.Length; i++)
            {                
                a[i] = rnd.Next(0, 30);
                for (int j = 0; j < i; j++)
                {
                    if (a[j] == a[i])
                    {
                        a[i] = rnd.Next(0, 30);
                    }
                }
            }
            Console.WriteLine(String.Join(",", a));
        }
    }
}
    

