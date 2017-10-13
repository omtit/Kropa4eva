using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie25
{
    class Program
    {
        static void Main(string[] args)
        {
            int y = int.Parse(Console.ReadLine());
            int x = 0;
            if (y < 0 || y > 15)
            {
                Console.WriteLine("	Значение Y должно быть в интервале [0, 15]");
            }
            else
            {
                while (x != 15)
                {
                    if (x < y)
                    {
                        Console.Write("#");                        
                    }
                    else 
                    {
                        Console.Write(".");                        
                    }
                    x = x + 1;
                }
            }
        }
    }
}
