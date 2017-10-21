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
            String str = "один, два, три, четыре, пять";
            string[] arr = str.Split(',');
            Console.WriteLine(arr.Length);
        }
    }
}
