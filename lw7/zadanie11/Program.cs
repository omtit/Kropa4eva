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
            string a = Console.ReadLine();
            int a1 = a.Length;
            if (a[0] != '"' || a[a1-1] != '"')
            {
                Console.WriteLine("Строка должна начинаться и заканчиваться кавычкой");
            }
            else
            {
                Console.WriteLine(a.Trim(' ', '"'));
            }

        }
    }
}
