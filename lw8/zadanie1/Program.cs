using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            String str = Console.ReadLine();

            if (String.IsNullOrEmpty(str))
            {
                Console.WriteLine();
                return;
            }
            String[] arr = str.Split(' ');
            if (a > arr.Length)
            {
                Console.WriteLine("Число A должно быть в интервале [0, размер массива)");
            }
            else
            {
                Console.WriteLine(arr[a]);
            }
        }

    }
}
