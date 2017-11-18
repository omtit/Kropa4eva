using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task5081
{
    class Lab13Task6081
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 4; a++)
            {
                String rel = "task5081\\test" + a + ".txt";
                try
                {
                    using (StreamReader str = new StreamReader(rel))
                    {
                        while (!str.EndOfStream)
                        {
                            try
                            {
                                String x = str.ReadLine();
                                if (!String.IsNullOrEmpty(x))
                                {
                                    String[] y = x.Split(',');
                                    int sum = 0;
                                    for (int i = 0; i < y.Length; i++)
                                    {
                                        sum += int.Parse(y[i]);
                                    }
                                    Console.WriteLine(sum);
                                }
                                else
                                {
                                    Console.WriteLine("Строка пуста");
                                }
                            }
                            catch (FormatException e)
                            {
                                Console.WriteLine("Не удается считать число");
                            }
                        }
                        Console.WriteLine();
                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Файл отсутствует");
                }
            }
        }
    }
}
