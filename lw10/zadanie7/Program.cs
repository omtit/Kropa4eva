using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            String testnum = Console.ReadLine();
            String rel = "task4769\\test" + testnum + ".txt";
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
                    String letter1 = Console.ReadLine();
                    String letter2 = Console.ReadLine();
                    String s1 = str.ReadLine();
                    int amount = 0;
                    if (s1.IndexOf(letter1) == -1 || s1.IndexOf(letter2) ==-1)
                    {
                        Console.WriteLine("Одна из указанных букв не найдена");
                        return;
                    }
                    for (int i = 0; i < s1.Length - 1; i++)
                    {
                        if (s1.Substring(i, 1) == letter1 || s1.Substring(i,1) == letter2)
                        {
                            amount++;
                        }
                    }
                    if (amount > 2 || letter1 == letter2)
                    {
                        Console.WriteLine("В данной строке несколько искомых букв");
                    }
                    else
                    {
                        if (s1.IndexOf(letter1) > s1.IndexOf(letter2))
                        {
                            amount = s1.IndexOf(letter1) - s1.IndexOf(letter2)-1;
                        }
                        else
                        {
                            amount = s1.IndexOf(letter2) - s1.IndexOf(letter1)-1;
                        }
                        Console.WriteLine(amount);
                    }
                }
            }
        }
    }
}
