using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefwxyz";
            string ca = Console.ReadLine();
            string cb = Console.ReadLine();
            int l = str.IndexOf(ca), k = str.IndexOf(cb);
            if (l == -1)
            {
                Console.WriteLine("Значение CA отсутствует в строке");
                return;
            }
            if (k == -1)
            {
                Console.WriteLine("Значение CB отсутствует в строке");
                return;
            }
            if (l - 1 == 1 || k - l == 1)
            {
                Console.WriteLine();
                return;
            }
            if (l < k)
            {
                while (l < k - 1)
                {
                    Console.Write(str[l + 1]);
                    l++;
                }
                Console.WriteLine();
            }
            else
            {
                while (k < l - 1)
                {
                    Console.Write(str[k + 1]);
                    k++;
                }
                Console.WriteLine();
            }

        }
    }
}
