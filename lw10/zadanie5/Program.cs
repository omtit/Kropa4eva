using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            int amount = 0;
            String rel = "task5537\\test" + a + ".txt";
            if (!File.Exists(rel))
            {
                Console.WriteLine("Файл {0} не существует", Path.GetFullPath(rel));
                return;
            }
            using (StreamReader str = new StreamReader(rel))
            {
                if (str.EndOfStream)
                {
                    Console.WriteLine("Файл пуст");
                }
                else
                {
                    while (!str.EndOfStream)
                    {
                        String s1 = str.ReadLine();
                        if (s1.Length < 4)
                        {
                            Console.WriteLine("Запись короче четырех символов");
                            return;
                        }
                        if (s1.Length > 4)
                        {
                            Console.WriteLine("Запись длиннее четырех символов");
                            return;
                        }
                        for (int i = 0; i < s1.Length - 1; i++)
                        {
                            if (s1[i] == s1[i + 1])
                            {
                                amount++;
                                break;
                            }
                        }
                    }
                    Console.WriteLine(amount);
                }                
            }
        }
    }
}

