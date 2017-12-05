using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Classes.Form;

namespace task2033
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Form F1 = new Form();
            F1.Top(sb);
            for (int i = 1; i < 19; i++)
            {
                F1.Mid1(sb, i);
                String rel = "task2033\\test" + i + ".csv";
                Dictionary<string, Shape> D1 = new Dictionary<string, Shape>();
                try
                {
                    using (StreamReader str = new StreamReader(rel))
                    {
                        while (!str.EndOfStream)
                        {
                            String s = str.ReadLine();
                            String[] s1 = s.Split(';');
                            if (s.Contains("create") && (s1.Length == 7 || s1.Length == 6))
                            {
                                if (!D1.ContainsKey(s1[2]))
                                {
                                    if (s1[1] == "rectangle" && s1.Length == 7)
                                    {
                                        D1.Add(s1[2], new Rectangle(int.Parse(s1[3]), int.Parse(s1[4]), int.Parse(s1[5]), int.Parse(s1[6]), s1[2]));
                                    }
                                    else if (s1[1] == "circle" && s1.Length == 6)
                                    {
                                        D1.Add(s1[2], new Circle(int.Parse(s1[3]), int.Parse(s1[4]), int.Parse(s1[5]), s1[2]));
                                    }
                                    else
                                    {
                                        sb.Append("<p>Некорректный формат<p/>");
                                    }
                                }
                                else
                                {
                                    sb.AppendFormat($"<p>Ошибка: Идентификатор не должен повторяться ({s1[2]})<p/>");
                                }
                            }
                            else if ((s.Contains("shiftX") || s.Contains("shiftY") || s.Contains("stretchX") || s.Contains("stretchY")) && s1.Length == 3)
                            {
                                if (D1.ContainsKey(s1[1]))
                                {
                                    Shape r1 = D1[s1[1]];

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
                                    sb.AppendFormat($"<p>Ошибка: Операция над неопознанным объектом {s1[1]}<p/>");
                                }
                            }
                            else
                            {
                                sb.Append("<p>Некорректный формат<p/>");
                            }
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    sb.Append(ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    sb.AppendFormat($"<p>Файл {Path.GetFullPath(rel)} не найден<p/>");
                    continue;
                }
                catch (FormatException ex)
                {
                    sb.Append("<p>Не удается считать число<p/>");
                }
                if (D1.Count != 0)
                {
                    foreach (var e in D1.Keys)
                    {
                        sb.AppendFormat($"<p>{D1[e].Id} Действий: {D1[e].Changes} {D1[e].ShowC()}<p/>");
                    }
                    F1.CreaeI(sb);
                    foreach (var e in D1.Keys)
                    {
                        sb.Append(D1[e].Print());
                    }
                    F1.CloseI(sb);
                }
            }
            F1.Bot(sb);
        }
    }
}

