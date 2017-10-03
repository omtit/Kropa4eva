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
            String x = Console.ReadLine();
            if (x == "a")
            {
                Console.WriteLine("a+\nb\nc\nd\ne\nf\ng\nh");
            }
            if (x == "b")
            {
                Console.WriteLine("a\nb+\nc\nd\ne\nf\ng\nh");
            }
            if (x == "c")
            {
                Console.WriteLine("a\nb\nc+\nd\ne\nf\ng\nh");
            }
            if (x == "d")
            {
                Console.WriteLine("a\nb+\nc\nd+\ne\nf\ng\nh");
            }
            if (x == "e")
            {
                Console.WriteLine("a\nb\nc\nd\ne+\nf\ng\nh");
            }
            if (x == "f")
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf+\ng\nh");
            }
            if (x == "g")
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf\ng+\nh");
            }
            if (x == "h")
            {
                Console.WriteLine("a\nb\nc\nd\ne\nf\ng\nh+");
            }
        }
    }
}
