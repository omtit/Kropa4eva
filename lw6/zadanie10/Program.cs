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
            int sum = 0, a = int.Parse(Console.ReadLine()), b = int.Parse(Console.ReadLine());
            while (a <= b) 
            {
                sum += a;
                Console.Write(sum + " ");
                a = a + 1;
            }
            Console.WriteLine();
            Console.WriteLine("Ответ:" + sum);
       
        }
    }
}
