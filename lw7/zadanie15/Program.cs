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
            string a = Console.ReadLine();
            int j = 0;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                string c = a.Substring(i, 1);
                if (c == "{")
                {
                    j++;
                }
                if (c == "}")
                {
                    j--;
                }                
                if (j < 0)
                {
                    Console.Write(" Неожиданная закрывающаяся скобка");
                }
                else
                {
                    Console.Write(j);
                }
            }
            if (j != 0)
            {
                Console.Write(" Неожиданный конец строки");
            }
        }
    }
}
