using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task5108
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 15; i++)
            {

                String rel = "task5108\\test" + i + ".csv";
                List<string> Changes = new List<string>();
                List<Rectangle> R1 = new List<Rectangle>();
                try
                {
                    Console.WriteLine(i+"\n");
                    using (StreamReader str = new StreamReader(rel))
                    {                        
                        while (!str.EndOfStream)
                        {
                            String s = str.ReadLine();
                            String[] s1 = s.Split(';');
                            if (s.Contains("create") && s1.Length == 6)
                            {
                                bool Exists = false;
                                foreach (Rectangle r in R1)
                                {
                                    if (s1[1] == r.Id)
                                    {
                                        Exists = true;
                                    }                                    
                                }
                                if (!Exists)
                                {
                                    R1.Add(new Rectangle(int.Parse(s1[2]), int.Parse(s1[3]), int.Parse(s1[4]), int.Parse(s1[5]), s1[1]));
                                }
                                else
                                {
                                    Console.WriteLine($"Фигура с таким id {s1[1]} уже существует");
                                }
                            }
                            else if ((s.Contains("shiftX") || s.Contains("shiftY") || s.Contains("stretchX") || s.Contains("stretchY")) && s1.Length == 3)
                            {
                                Changes.Add(s);
                            }
                            else
                            {
                                Console.WriteLine("Некорректный формат");
                            }
                        }          
                        foreach (Rectangle e in R1)
                        {
                            foreach (String a in Changes)
                            {
                                String[] a1 = a.Split(';');
                                if (a.Contains(e.Id))
                                {
                                    if (a1[0] == "shiftX")
                                    {
                                        e.ShiftX(int.Parse(a1[2]));
                                    }
                                    if (a1[0] == "shiftY")
                                    {
                                        e.ShiftY(int.Parse(a1[2]));
                                    }
                                    if (a1[0] == "stretchX")
                                    {
                                        e.StretchX(int.Parse(a1[2]));
                                    }
                                    if (a1[0] == "stretchY")
                                    {
                                        e.StretchY(int.Parse(a1[2]));
                                    }
                                }
                            }
                        }
                    }                    
                }
                catch(ArgumentException ex)
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
                foreach (Rectangle e in R1)
                {
                    Console.WriteLine(e.Print());
                }
            }
        }}
    }
