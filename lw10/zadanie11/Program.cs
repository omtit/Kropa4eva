using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            String testnum = Console.ReadLine();
            String rel = "task4372\\test" + testnum + ".css";
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
                    String symbol = "{";
                    if (s.Contains(symbol))
                    {
                        s = s.Remove(s.IndexOf(symbol));
                        Console.WriteLine(s);
                    }
                }
            }
        }
    }
}
