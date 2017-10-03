using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            String lnm,lncm;
            lnm = Console.ReadLine();
            lncm = Console.ReadLine();
            int a,b,c,d;
            a = 100*int.Parse(lnm);
            if (a <= 0)
            {
                Console.WriteLine("Значение lnm должно быть положительным");
                return;
            }
            b = int.Parse(lncm);
            if (b <= 0) 
            {
                Console.WriteLine("Значение lncm должно быть положительным");
                return;
            }
            c = a / b;
            d = a % b;
            Console.WriteLine(c + "шт и " + d +"см");
        }
    }
}
