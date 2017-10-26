using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            String s1 = Console.ReadLine();
            if (String.IsNullOrEmpty(s1))
            {
                Console.WriteLine();
                return;
            }
            String[] a1 = s1.Split(' ');          
            int i, j = 0, amount = 0;
            while (j < a1.Length)
            {
                i =j+1;
                while (i < a1.Length)
                {
                    if (a1[j] == a1[i])
                    {
                        amount++;
                    }
                    i++;
                }
                j++;
            }
            if(amount > 0)
            {
                Console.WriteLine("Повторения есть");
            }
            else
            {
                Console.WriteLine("Повторений нет");
            }
        }
    }
}
