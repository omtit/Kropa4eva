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
                    String rel = "task9472\\test" + a + ".csv";
                    using (StreamReader str = new StreamReader(rel))
                    {
                        if (!str.EndOfStream)
                        {
                            String x = str.ReadLine();
                            String[] x1 = x.Split(';');
                            if (!x.Contains("rect") && !x.Contains("circle") && (x1.Length != 5 || x1.Length != 4))
                            {
                                Console.WriteLine("Сообщение об ошибке");
                            }
                            else
                            {
                                double s = 0, s1 = 0;
                                if (x1[0] == "rect" && x1.Length == 5)
                                {
                                    s = double.Parse(x1[3]) * double.Parse(x1[4]);
                                }
                                if (x1[0] == "circle" && x1.Length == 4)
                                {
                                    s = Math.PI * Math.Pow(double.Parse(x1[3]), 2);
                                }
                                else
                                {
                                    Console.WriteLine("Некорректный формат данных");
                                    continue;
                                }
                                while (!str.EndOfStream)
                                {
                                    String[] x2 = str.ReadLine().Split(';');
                                    if (x1[0] == "rect" && x1.Length == 5)
                                    {
                                        s1 = double.Parse(x2[3]) * double.Parse(x2[4]);
                                        if (s1 > s)
                                        {
                                            s = s1;
                                        }
                                    }
                                    if (x1[0] == "circle" && x1.Length == 4)
                                    {
                                        s1 = Math.PI * Math.Pow(double.Parse(x2[3]), 2);
                                        if (s1 > s)
                                        {
                                            s = s1;
                                        }
                                    }
                                    Console.WriteLine(s1);
                                    Console.WriteLine(s);
                                }
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
                catch (Exception e)
                {
                    Console.WriteLine("что то пошло не так");
                }
            }
        }
    }
}
