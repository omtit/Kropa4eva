using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,i = 1;
            while (i <= 9)
            {
                x = i * 7;
                Console.WriteLine("{0} x 7 = {1}",i,x);
                i++;
            }
        }
    }
}
