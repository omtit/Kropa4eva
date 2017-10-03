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
            String CX, CY, R, FILL;
            CX = Console.ReadLine();
            CY = Console.ReadLine();
            R = Console.ReadLine();
            FILL = Console.ReadLine();
            Console.WriteLine("<circle cx=\"" + CX + "\" cy=\"" + CY + "\"\nr=\""+ R + "\" fill=\""+ FILL + "\"/>");
        }
    }
}
