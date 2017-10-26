using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie20
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
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            if (p < 0 || q < 0 || p > s1.Length - 1 || q > s1.Length - 1)
            {
                Console.WriteLine("Сообщение об ошибке");
                return;
            }
            int k = 0;
            String[] a1 = s1.Split(' ');
            if (p < q)
            {
                k = int.Parse(a1[p]);
                while (p < q)
                {
                    int a22 = int.Parse(a1[p + 1]);
                    if (k > a22)
                    {
                        k = a22;
                    }
                    p++;
                }
            }
            else
            {
                k = int.Parse(a1[q]);
                while (q < p)
                {
                    int a22 = int.Parse(a1[q + 1]);
                    if (k > a22)
                    {
                        k = a22;
                    }
                    q++;
                }
            }
            Console.WriteLine(k);
        }
    }
}
