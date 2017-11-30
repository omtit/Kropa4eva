using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie5_9924
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {                
                String r = "task9924\\test" + i + ".csv";
                int b = 0;
                try
                {
                    using (StreamReader str = new StreamReader(r))
                    {
                        if (!str.EndOfStream)
                        {
                            HashSet<Point> HS = new HashSet<Point>();
                            while (!str.EndOfStream)
                            {
                                Point P1 = new Point();
                                String a = str.ReadLine();
                                if (a == null || !a.Contains(";"))
                                {
                                    Console.WriteLine("Некорректный формат");
                                    b++;
                                    break;                                  
                                }
                                String[] a1 = a.Split(';');
                                if (a1.Length != 3)
                                {
                                    Console.WriteLine("Некорректный формат");
                                    b++;
                                    break;
                                    
                                }
                                P1.X = int.Parse(a1[0]);
                                P1.Y = int.Parse(a1[1]);
                                P1.Color = a1[2];
                                HS.Add(P1);
                            }
                            if (b == 0)
                            {
                                foreach (Point x in HS)
                                {
                                    Console.WriteLine(x.ToString());
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Файл пуст");
                        }
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Не удается считать число");
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Файл не найден");
                }
                Console.WriteLine("\n");

            }

        }
    }
}
