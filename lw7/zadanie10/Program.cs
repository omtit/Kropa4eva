using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = "abcdacadbacdaabaadc";
            String b = Console.ReadLine();
            if (b.Length != 2)
            {
                Console.WriteLine("Вводимая строка должна содержать ровно 2 символа");
            }
            else
            {
                Console.WriteLine(a.Replace(b," "));                 
            }
        }
    }
}
