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
            String X, Y;
            X = Console.ReadLine();
            Y = Console.ReadLine();
            Console.WriteLine("INSERT INTO POINTS (x, y) VALUES ('" + X + "', '" + Y + "');");
        }
    }
}
