using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();            
            String s1 = "";
            String rel = "task4642\\test" + a + ".txt";
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
                        String s2 = str.ReadLine();
                        s1 = s1 + s2 + " ";
                    }
                    for (int j = 0; j < s1.Length; j++)
                    {
                        for (int i = 0; i < s1.Length - 1; i++)
                        {
                            if (s1[i] == ' ' && s1[i + 1] == ' ')
                            {
                                s1 = s1.Replace("  ", " ");
                            }
                        }
                    }                    
                    String[] a1 = s1.Split(' ');
                    Console.WriteLine(a1.Length);
                }
            }
        }
    }
}
