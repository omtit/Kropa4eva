using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task5108v2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 15; i++)
            {

                String rel = "task5108\\test" + i + ".csv";
                Dictionary<string, Rectangle> D1 = new Dictionary<string, Rectangle>();
                List<string> Changes = new List<string>();

                try
                {
                    Console.WriteLine(i + "\n");
                    using (StreamReader str = new StreamReader(rel))
                    {
                        while (!str.EndOfStream)
                        {
                            String s = str.ReadLine();
                            String[] s1 = s.Split(';');
                           
                            if (s.Contains("create") && s1.Length == 6)
                            {
                                if (!D1.ContainsKey(s1[1]))
                                {
                                    D1.Add(s1[1], new Rectangle(int.Parse(s1[2]), int.Parse(s1[3]), int.Parse(s1[4]), int.Parse(s1[5]), s1[1]));
                                }
                                else
                                {
                                    Console.WriteLine($"Фигура с таким id {s1[1]} уже существует");
                                }
                            }
                            else if ((s.Contains("shiftX") || s.Contains("shiftY") || s.Contains("stretchX") || s.Contains("stretchY")) && s1.Length == 3)
                            {
                                if (D1.ContainsKey(s1[1]))
                                {
                                    Rectangle r1 = D1[s1[1]];

                                    if (s1[0] == "shiftX")
                                    {
                                        r1.ShiftX(int.Parse(s1[2]));
                                    }
                                    if (s1[0] == "shiftY")
                                    {
                                        r1.ShiftY(int.Parse(s1[2]));
                                    }
                                    if (s1[0] == "stretchX")
                                    {
                                        r1.StretchX(int.Parse(s1[2]));
                                    }
                                    if (s1[0] == "stretchY")
                                    {
                                        r1.StretchY(int.Parse(s1[2]));
                                    }
                                }
                                else
                                {
                                    Console.WriteLine($"Ошибка: Операция над неопознанным объектом {s1[1]}");
                                }
                            }                            
                            else
                            {
                                Console.WriteLine("Некорректный формат");
                            }
                        }  
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine($"Файл {Path.GetFullPath(rel)} не найден");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Не удается считать число");
                }
                foreach (var e in D1.Keys)
                {
                    Console.WriteLine(D1[e].Print());
                }
            }
        }
    }
}
