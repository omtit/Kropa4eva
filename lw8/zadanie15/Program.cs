using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie15
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = Console.ReadLine();
            if (String.IsNullOrEmpty(s1))
            {
                Console.WriteLine("0");
                return;
            }
            String[] a1 = s1.Split(' ');
            int a =0,sum = 0;
            for (int i=0; i < a1.Length; i++)
            {
                sum += int.Parse(a1[i]); 
            }
            a = sum / a1.Length;
            Console.WriteLine("Среднее арифметическое: {0}",a);
        }
    }
}
