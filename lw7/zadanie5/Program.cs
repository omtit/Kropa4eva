using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "abcdefwxyz";
            int ca = int.Parse(Console.ReadLine());             int a = str.Length;
            if (ca > a || ca < 0)
            {
                Console.WriteLine("Значение CA должно быть в интервале [0,длина строки)");
                return;
            }
            int cb = int.Parse(Console.ReadLine());
            if (cb > a || cb < 0)
            {
                Console.WriteLine("Значение CB должно быть в интервале [0,длина строки)");
                return;
            }
            if ( cb < ca)
            {
                Console.WriteLine("Значение CA должно быть меньше CB");
            }
            else
            {
                string part = str.Substring(ca, cb);
                Console.WriteLine(part);
            }
        }
    }
}
