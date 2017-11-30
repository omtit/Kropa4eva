using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie4_7738
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 5; i++)
            {
                String r = "task7738\\test" + i + ".txt";
                try
                {
                    Console.WriteLine(i);
                    using (StreamReader str = new StreamReader(r))
                    {
                        Dictionary<String, int> dct = new Dictionary<String, int>();
                        while (!str.EndOfStream)
                        {
                            String a = str.ReadLine();
                            if (dct.ContainsKey(a))
                            {
                                dct[a]++;
                            }
                            else
                            {
                                dct.Add(a, 1);
                            }
                        }
                        foreach (var a in dct)
                        {
                            Console.WriteLine(a.Key + " " + a.Value);
                        }
                    }
                    Console.WriteLine("\n");
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Файл не найден");
                }
            }

        }
    }
}
