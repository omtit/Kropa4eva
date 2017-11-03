using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            String testnum = Console.ReadLine();
            String rel = "task3226\\test" + testnum + ".txt";
            String s = "";
            int j = 0, k = 0;
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
                    s = s + s1;
                }
                for (int i = 0; i <= s.Length - 1; i++)
                {

                    String c = s.Substring(i, 1);
                    if (c == "{")
                    {
                        j++;
                        if (j > k)
                        {
                            k = j;
                        }
                    }
                    if (c == "}")
                    {
                        j--;
                    }
                    if (j < 0)
                    {
                        Console.WriteLine("Неожиданная закрывающаяся скобка");
                        return;
                    }
                }
            }
            if (j != 0)
            {
                Console.WriteLine("Неожиданный конец файла");
            }
            else
            {
                Console.WriteLine(k);
            }
        }

    }
}

