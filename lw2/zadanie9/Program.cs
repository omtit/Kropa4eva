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
            int aRemainder, aInitial = int.Parse(Console.ReadLine());
            if (aInitial < 0)
            {
                aRemainder = 360 + (aInitial%360);
            }
            else
            {
                aRemainder = aInitial % 360;
            }
            Console.WriteLine(aRemainder);
        }
    }
}
