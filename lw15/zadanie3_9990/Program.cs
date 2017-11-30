using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie3_9990
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                String r = "task9990\\test" + i + ".txt";
                try
                {
                    using (StreamReader str = new StreamReader(r))
                    {
                        HashSet<String> HS1 = new HashSet<String>();
                        while (!str.EndOfStream)
                        {
                            HS1.Add(str.ReadLine());
                        }
                        Console.WriteLine(String.Join(";", HS1));
                    }
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Файл не найден");
                }
            }
        }
    }
}
