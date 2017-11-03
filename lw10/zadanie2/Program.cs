using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String s = "task4488\\test" + a + ".txt";
            if (!File.Exists(s))
            {
                Console.WriteLine("Файл {0} не найден", s);
                return;
            }
            using (StreamReader s1 = new StreamReader(s))
            {
                if (s1.EndOfStream)
                {
                    Console.WriteLine("Файл пуст");
                }
                else
                {
                    String s2 = s1.ReadLine();
                    Console.Write(s2 + " ");
                    int i = 0;
                    while (!s1.EndOfStream)
                    {
                        String a1 = s1.ReadLine();
                        i++;
                    }
                    Console.WriteLine(i);
                }
            }
        }
    }
}
