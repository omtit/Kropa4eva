using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            String testnum = Console.ReadLine();
            String kavi4ka = "\"";
            String rel = "task1668\\test" + testnum + ".html";
            if (!File.Exists(rel))
            {
                Console.WriteLine("Файл {0} не существует", Path.GetFullPath(rel));
                return;
            }
            using (StreamReader str = new StreamReader(rel))
            {
                while (!str.EndOfStream)
                {
                    String s = str.ReadLine();
                    int amount = 0;
                    for (int i = 0; i < s.Length; i++)
                    {
                        if (s.Substring(i,1) == kavi4ka)
                        {
                            amount++;
                            return;
                        }
                    }
                    if (amount == 6)
                    {
                        s = s.Replace(" ", "+");
                    }
                }
            }
        }
    }
}
