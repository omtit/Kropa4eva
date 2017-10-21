using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefwxyz";
            string ca = Console.ReadLine(), cb = Console.ReadLine();
            int m, i = str.IndexOf(ca);
            if (i == -1)
            {
                Console.WriteLine("Значение CA отсутствует в строке");
                return;
            }
            int j = str.IndexOf(cb);
            if (j == -1)
            {
                Console.WriteLine("Значение CB отсутствует в строке");
                return;
            }
            if (i > j)
            {
                m = i - j - 1;
                Console.WriteLine(m);
            }
            else
            {
                m = j - i - 1;
                Console.WriteLine(m);
            }



        }
    }
}
