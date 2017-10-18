using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie40
{
    class Program
    {
        static void Main(string[] args)
        {
            string a="",s1 = Console.ReadLine(), s2 = Console.ReadLine();
            int i = 1, j = 1;
            int w = int.Parse(Console.ReadLine());
            if (w < 0)
            {
                Console.WriteLine("Значение w должно быть неотрицательно");
                return;
            }
            if (w == 0)
            {
                return;
            }
            int h = int.Parse(Console.ReadLine());
            if (h < 0)
            {
                Console.WriteLine("Значение h должно быть неотрицательно");
                return;
            }
            if (h == 0)
            {
                return;
            }            
            while (i <= h)
            {
                if (i % 2 == 0)
                {
                    a = s2;
                }
                else
                {
                    a = s1;
                }
                while (j <= w)                
                {
                    Console.Write(a);
                    j++;
                }
                Console.WriteLine();
                j = 1;
                i++;
                                
            }
        }
    }
}
