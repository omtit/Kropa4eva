using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Classes.Form;

namespace task5108
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            Form F = new Form();
            F.Top(sb);
            for (int i = 1; i < 15; i++)
            {
                F.Mid1(sb, i);
                String rel = "task5108\\test" + i + ".csv";
                List<string> Changes = new List<string>();
                List<Rectangle> R1 = new List<Rectangle>();
                try
                {
                    using (StreamReader str = new StreamReader(rel))
                    {
                        while (!str.EndOfStream)
                        {
                            String s = str.ReadLine();
                            String[] s1 = s.Split(';');
                            if (s.Contains("create") && s1.Length == 6)
                            {
                                int YN = 0;
                                foreach (Rectangle r in R1)
                                {
                                    if (s1[1] == r.Id)
                                    {
                                        YN++;
                                    }
                                }
                                if (YN == 0)
                                {
                                    R1.Add(new Rectangle(int.Parse(s1[2]), int.Parse(s1[3]), int.Parse(s1[4]), int.Parse(s1[5]), s1[1]));
                                }
                                else
                                {
                                    sb.AppendFormat($"<p>Фигура с таким id {s1[1]} уже существует<p/>");
                                }
                            }
                            else if ((s.Contains("shiftX") || s.Contains("shiftY") || s.Contains("stretchX") || s.Contains("stretchY")) && s1.Length == 3)
                            {
                                Changes.Add(s);
                            }
                            else
                            {
                                sb.Append("<p>Некорректный формат<p/>");
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
                                        e.Changes++;
                                    }
                                    if (a1[0] == "shiftY")
                                    {
                                        e.ShiftY(int.Parse(a1[2]));
                                        e.Changes++;
                                    }
                                    if (a1[0] == "stretchX")
                                    {
                                        e.StretchX(int.Parse(a1[2]));
                                        e.Changes++;
                                    }
                                    if (a1[0] == "stretchY")
                                    {
                                        e.StretchY(int.Parse(a1[2]));
                                        e.Changes++;
                                    }
                                }
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
                    sb.Append($"Файл {Path.GetFullPath(rel)} не найден");
                    continue;
                }
                catch (FormatException ex)
                {
                    sb.Append("<p>Не удается считать число<p/>");
                }
                if (R1.Count != 0)
                {
                    foreach (Rectangle e in R1)
                    {
                        sb.AppendFormat($"<p>{e.Id} Действий: {e.Changes}<p/>\n");
                    }
                    F.CreaeI(sb);
                    foreach (Rectangle e in R1)
                    {
                        sb.Append(e.Print());
                    }
                    F.CloseI(sb);
                }
            }
            F.Bot(sb);
        }
    }
}
