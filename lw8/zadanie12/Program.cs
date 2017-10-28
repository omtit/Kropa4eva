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
            String s1 = Console.ReadLine();
            if (String.IsNullOrEmpty(s1))
            {
                Console.WriteLine("Данные сверху отсутствуют");
                return;
            }
            String s2 = Console.ReadLine();
            if (String.IsNullOrEmpty(s2))
            {
                Console.WriteLine("Данные слева отсутствуют");
                return;
            }
            String[] a1 = s1.Split(' ');
            String[] a2 = s2.Split(' ');
            int i = 0, j = 0, amount = 0;
            while (j < a1.Length)
            {
                i = 0;
                while (i < a2.Length)
                {                    
                    if (a1[j] == a2[i])
                    {
                        amount++;
                    }
                    i++;
                }
                j++;
            }
            Console.WriteLine("Повторений: {0}",amount);
        }
    }
}
