using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0,a = -10, b = int.Parse(Console.ReadLine());
            if (b > 10000 || b < a)
            {
                Console.WriteLine("Значение b должно быть в интервале [-10,10000]");
                return;
            }
            else
            {
                while (a <= b)
                {
                    sum += b;
                    b--;
                }
                Console.WriteLine(sum);
            }
        }
    }
}
