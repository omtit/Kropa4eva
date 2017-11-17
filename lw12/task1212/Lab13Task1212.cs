using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1212
{
    class Lab13Task1212
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 9; a++)
            {
                try
                {
                    String rel = "task1212\\test" + a + ".csv";
                    using (StreamReader str = new StreamReader(rel))
                    {
                        if (!str.EndOfStream)
                        {
                            String[] x = str.ReadLine().Split(';');
                            if (x.Length != 4)
                            {
                                Console.WriteLine("Некорректный формат данных");
                            }
                            else
                            {
                                int s = int.Parse(x[2]) * int.Parse(x[3]);
                                while (!str.EndOfStream)
                                {
                                    String[] x1 = str.ReadLine().Split(';');
                                    int s1 = int.Parse(x1[2]) * int.Parse(x1[3]);
                                    if (s1 > s)
                                    {
                                        s = s1;
                                    }
                                }
                                Console.WriteLine(s);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Файл пуст");
                        }
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Не удается считать число");
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Файл не существует");
                }

            }
        }
    }
}
