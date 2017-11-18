using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task9472
{
    class Lab13Task9472
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 8; a++)
            {
                try
                {
                    double s1 = 0, s;
                    String rel = "task9472\\test" + a + ".csv";
                    using (StreamReader str = new StreamReader(rel))
                    {
                        if (!str.EndOfStream)
                        {
                            while (!str.EndOfStream)
                            {
                                String x = str.ReadLine();
                                String[] x1 = x.Split(';');
                                if (!x.Contains("rect") && !x.Contains("circle") && (x1.Length != 5 || x1.Length != 4))
                                {
                                    Console.WriteLine("Сообщение об ошибке");
                                    break;
                                }
                                else
                                {
                                    if (x1[0] == "rect" && x1.Length == 5)
                                    {
                                        s = double.Parse(x1[3]) * double.Parse(x1[4]);
                                        if (s > s1)
                                        {
                                            s1 = s;
                                        }
                                    }
                                   else if (x1[0] == "circle" && x1.Length == 4)
                                    {
                                        s = Math.PI * Math.Pow(double.Parse(x1[3]), 2);
                                        if (s > s1)
                                        {
                                            s1 = s;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Неверный формат");
                                    }
                                }
                            }
                            if (s1 != 0)
                            {
                                Console.WriteLine("{0:F4}", s1);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Файл пуст");
                        }
                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Файл не существует");
                }
            }
        }
    }
}
