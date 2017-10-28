using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = Console.ReadLine();
            if (String.IsNullOrEmpty(s1))
            {
                Console.WriteLine("Данные сверху отсутствуют");
                return;
            }
            String s2 = Console.ReadLine();           
            if (String.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Данные слева отсутствуют");
                return;
            }
            String[] a1 = s1.Split(' ');
            String[] a2 = s2.Split(' ');
            int i = 0, j = 0;
            Console.WriteLine("  "+s1.Replace("_",""));
            while (j < a2.Length)
            {
                i = 0;
                Console.Write(a2[j] +" ");
                while (i < a1.Length)
                {
                    if (a2[j] == a1[i])
                    {
                        Console.Write("+ ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }                    
                    i++;
                }
                Console.WriteLine("|");
                j++;                
            }
            Console.Write(" ");
            for (i = 0; i < (s1.Length+2); i++)
            {
                Console.Write("-");
            }
            Console.Write(" ");
        }
    }
}
