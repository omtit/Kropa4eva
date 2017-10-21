using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lw7
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefwxyz";
            string a = Console.ReadLine();
            if (str.Contains(a))
            {
                Console.WriteLine("Содержится");
            }
            else
            {
                Console.WriteLine("Не содержится");
            }
        }
    }
}
