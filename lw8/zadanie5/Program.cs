using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            String e, str = Console.ReadLine();
            String[] a = str.Split(' ');
            if (p > a.Length || p < 0)
            {
                Console.WriteLine("Число P должно быть в интервале [0, размер массива)");
                return;
            }
            
            if (q > a.Length || q < 0)
            {
                Console.WriteLine("Число Q должно быть в интервале [0, размер массива)");
                return;
            }
            e = a[p];
            a[p] = a[q];
            a[q] = e;
            int i = 0;
            while (i < a.Length)
            {
                Console.Write(a[i]+ " ");
                i++;
            }
        }
    }
}
