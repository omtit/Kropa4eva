using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie14
{
    class Program
    {
        static void Main(string[] args)
        {
            String testnum = Console.ReadLine();
            String rel = "task2137\\test" + testnum + ".txt";
            String s1 = "";
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
                    s1 = s1 + s;
                }
                s1 = s1.Replace(" ", "");
                String letter = Console.ReadLine();
                int amount = 0;
                String zpt = ",", kavi4ka = "\"";  
                int a = 0;
                for (int i = 0; i < s1.Length - 1; i++)
                {
                    if(s1.Substring(i, 1) == kavi4ka && s1.Substring(i + 1, 1) == zpt && s1.Substring(i, 1) == kavi4ka)
                    {
                        a++;
                    }                    
                }    
                if (a == 0 || !s1.EndsWith(kavi4ka) || !s1.StartsWith(kavi4ka))
                {
                    Console.WriteLine("Фрагменты должны быть в кавычках и разделены запятыми");
                    return;
                }
                s1 = s1.Substring(1, s1.Length - 2);
                for (int i = 0; i < s1.Length - 1; i++)
                {
                    if (s1.Substring(i, 1) == letter)
                    {
                        amount++;
                    }
                    if (s1.Substring(i, 1) == kavi4ka && s1.Substring(i + 1, 1) == zpt)
                    {
                        Console.Write(amount + " ");
                        i = i + 2;
                        amount = 0;
                    }
                }
                Console.WriteLine(amount);
            }
        }
    }
}



