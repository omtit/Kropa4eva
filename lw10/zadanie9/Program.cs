using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            String testnum = Console.ReadLine();
            String rel = "task6861\\test" + testnum + ".txt";
            if (!File.Exists(rel))
            {
                Console.WriteLine("Файл {0} не существует", Path.GetFullPath(rel));
                return;
            }
            using (StreamReader str = new StreamReader(rel))
            {
                while (!str.EndOfStream)
                {
                    String s1 = str.ReadLine();
                    String symbol1 = "@", symbol2 = ".";
                    if (s1.IndexOf(symbol1) == -1 || s1.IndexOf(symbol2) == -1 || s1.Length < 6 || s1.IndexOf(symbol1) != s1.LastIndexOf(symbol1))
                    {
                        Console.WriteLine("Некорректный почтовый адрес");
                    }
                    else
                    {
                        s1 = s1.Remove(s1.LastIndexOf(symbol1));
                        Console.WriteLine(s1);
                    }
                }
            }
        }
    }
}
