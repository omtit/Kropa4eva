using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            String testnum = Console.ReadLine();
            String rel = "task9930\\test" + testnum + ".txt";
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
                    if (s1.IndexOf("\\") != -1)
                    {
                        int a = s1.LastIndexOf("\\");
                        s1 = s1.Remove(0, a + 1);
                    }
                    if (s1.IndexOf(".") != -1)
                    {
                        int b = s1.IndexOf(".");
                        s1 = s1.Remove(b);
                    }
                    if (s1.Contains("*") || s1.Contains("|") || s1.Contains(":") || s1.Contains("\"") || s1.Contains("<") || s1.Contains(">") || s1.Contains("/") || s1.Contains("?"))
                    {
                        Console.WriteLine("Некорректное имя файла");
                    }
                    else
                    {
                        Console.WriteLine(s1);
                    }
                }
            }
        }
    }
}
