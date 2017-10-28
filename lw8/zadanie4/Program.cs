using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            String s = Console.ReadLine();
            String[] s1 = s.Split(' ');
            if (b < 0 || b > s1.Length)
            {
                Console.WriteLine("Число B должно быть в интервале [0, размер массива)");
                return;
            }
            if (e < 0 || e > s1.Length)
            {
                Console.WriteLine("Число E должно быть в интервале [0, размер массива)");
                return;
            }
            if (b <= e)
            {
                while (b <= e)
                {
                    Console.Write(s1[b] + " ");
                    b++;
                }
            }
            else
            {
                while (e < b)
                {
                    Console.Write(s1[e]);
                    e++;
                }
            }
        }
    }
}
