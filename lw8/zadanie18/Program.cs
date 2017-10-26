using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie18
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
            String[] a1 = s1.Split(' ');
            int k = int.Parse(a1[0]);
            Console.WriteLine("Ход решения:\nНачинаю с {0}", a1[0]);
            for (int i = 1; i < a1.Length; i++)
            {
                int a2 = int.Parse(a1[i]);
                Console.WriteLine("Сравниваю {0} и {1}",k,a2);
                if (a2 < k)
                {
                    k = a2;
                    Console.WriteLine("Заменяю");
                }
            }
            Console.WriteLine("Ответ: {0}",k);
        }
    }
}
