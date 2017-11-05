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
            int x = int.Parse(Console.ReadLine());
            int[] a = new int[x];
            Random rnd = new Random();
            int pribil = 0;
            double sr;
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(100, 999);
                pribil += a[i];
            }
            sr = pribil / (a.Length - 1);
            Console.WriteLine("Средний чек: {0}\nОбщая прибыль: {1}",sr,pribil);
        }
    }
}
