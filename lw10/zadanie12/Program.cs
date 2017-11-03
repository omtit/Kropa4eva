using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            String testnum = Console.ReadLine();
            int i = 0;
            String rel = "task4463\\test" + testnum + ".txt";
            if (!File.Exists(rel))
            {
                Console.WriteLine("Файл {0} не существует", Path.GetFullPath(rel));
                return;
            }
            using (StreamReader str = new StreamReader(rel))
            {
                while (!str.EndOfStream)
                {
                    String kavi4ka = "\"";
                    String s = str.ReadLine();
                    if (s.Contains(kavi4ka) && s.Contains("."))
                    {
                        s = s.Substring(s.IndexOf(kavi4ka)+1,s.LastIndexOf(kavi4ka)-s.IndexOf(kavi4ka)-1);
                        Console.WriteLine(s);
                        i++;
                    }                   
                }
                if (i == 0)
                {
                    Console.WriteLine("Файл не содержит скриптов");
                }
            }
        }
    }
}
