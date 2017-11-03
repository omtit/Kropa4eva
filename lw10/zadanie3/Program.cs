using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String z = Console.ReadLine();
            String s = "task4954\\test" + a + ".txt";
            if (!File.Exists(s))
            {
                Console.WriteLine("Файл {0} не найден", s);
                return;
            }
            using (StreamReader s1 = new StreamReader(s))
            {
                String s2 = s1.ReadLine();
                int i = 0;

                while (!s1.EndOfStream)
                {
                    String a1 = s1.ReadLine();
                    if (a1.Contains(z))
                    {
                        i++;
                    }

                }
                Console.WriteLine(i);
            }
        }
    }
}
