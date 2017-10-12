using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie34
{
    class Program
    {
        static void Main(string[] args)
        {
            int W = int.Parse(Console.ReadLine());
            if (W <= 0)
            {
                Console.WriteLine("Значение W должно быть положительным");
                return;
            }
            int H = int.Parse(Console.ReadLine());
            if (H <= 0)
            {
                Console.WriteLine("Значение H должно быть положительным");
                return;
            }
            int C = int.Parse(Console.ReadLine());
            if (C <= 0)
            {
                Console.WriteLine("Значение C должно быть положительным");
                return;
            }
            int D = int.Parse(Console.ReadLine());
            if (D <= 0)
            {
                Console.WriteLine("Значение D должно быть положительным");
                return;
            }
            int S1, S2, x1, y1, x2, y2;
            x1 = W / C; y1 = H / D;
            S1 = x1 * y1;
            x2 = W / D; y2 = H / C;
            S2 = x2 * y2;
            if (S1 > S2)
            {
                Console.WriteLine(S1 + " при С вдоль W");
            }
            else
            {
                Console.WriteLine(S2 + " при С вдоль H");
            }
        }
    }
}
