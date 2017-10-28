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
            string str = "abcdefwxyz";
            int ca = int.Parse(Console.ReadLine());
            int a = str.Length;
            if (ca > a || ca < 0)
            {
                Console.WriteLine("Значение CA должно быть в интервале [0,длина строки)");
                return;
            }
            int cb = int.Parse(Console.ReadLine());
            if (cb < 0)
            {
                Console.WriteLine("Значение CB должно быть неотрицательно");
                return;
            }
            if ((cb + ca) > a)
            {
                Console.WriteLine("Сумма значений CA и CB должна быть меньше длины строки");
                return;
            }
            string str1 = str.Remove(ca, cb);
            for (int j = 0; j < str1.Length; j++)
            {
                Console.Write(str1[j]);
            }
            Console.WriteLine();
        }
    }
}
