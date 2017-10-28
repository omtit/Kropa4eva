using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie17
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
            int b = int.Parse(Console.ReadLine());
            String[] a1 = s1.Split(' ');
            if (b < 0 || b > a1.Length - 1)
            {
                Console.WriteLine("Число B должно быть в интервале [0, размер массива)");
            }
            else
            {
                int amount = 0;
                int b1 = int.Parse(a1[b]);
                for (int i = 0; i < b; i++)
                {
                    int a2 = int.Parse(a1[i]);
                    if (a2 < b1)
                    {
                        amount++;
                    }
                }
                for (int i = b + 1; i < a1.Length; i++)
                {
                    int a2 = int.Parse(a1[i]);
                    if (a2 < b1)
                    {
                        amount++;
                    }
                }
                Console.WriteLine(amount);
            }
        }
    }
}
