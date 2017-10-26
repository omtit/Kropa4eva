using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie16
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = Console.ReadLine();
            if (String.IsNullOrEmpty(s1))
            {
                Console.WriteLine("Данные слева отсутствуют");
                return;
            }
            String s2 = Console.ReadLine();
            if (String.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Данные справа отсутствуют");
                return;
            }
            String[] a1 = s1.Split(' ');
            String[] a2 = s2.Split(' ');
            if (a1.Length != a2.Length)
            {
                Console.WriteLine("Размеры массивов должны быть одинаковы");
            }
            else
            {
                for (int i = 0; i < a1.Length; i++)
                {
                    Console.Write(int.Parse(a1[i])*int.Parse(a2[i]) +" ");
                }
            }
        }
    }
}
