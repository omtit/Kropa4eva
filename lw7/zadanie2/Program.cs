using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefwxyz";
            string a = Console.ReadLine();
            int k,i = str.IndexOf(a);
            if (i == -1)
            {
                Console.WriteLine("Значение отсутствует в строке");
            }
            else
            {
                int length = str.Length;
                k = length - i - 1;
                Console.WriteLine(k);
            }
        }
    }
}
