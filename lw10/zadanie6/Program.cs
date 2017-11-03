using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace zadanie6
{
    class Program
    {
        static void Main(string[] args)
        {
            String testnum = Console.ReadLine();
            String rel = "task5847\\test" + testnum + ".txt";
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
                    String letter = Console.ReadLine();
                    String s1 = str.ReadLine();
                    int amount = 0;
                    if (s1.IndexOf(letter) == -1)
                    {
                        Console.WriteLine("Указанная буква не найдена");
                        return;
                    }
                    for (int i = 0; i < s1.Length; i++)
                    {
                        if (s1.Substring(i,1) == letter)
                        {
                            amount++;
                        }
                    }
                    if (amount > 1)
                    {
                        Console.WriteLine("В данной строке несколько искомых букв");
                    }
                    else
                    {
                        String s2 = s1.Substring(s1.IndexOf(letter));
                        Console.WriteLine(s2.Length - 1);
                    }
                }
            }
        }
    }
}
