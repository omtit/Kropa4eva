using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task5032
{
    class Lab14Task5032
    {
        static void Main(string[] args)
        {
            StringBuilder sb5032 = new StringBuilder();
            String result = "res.html";
            
            sb5032.Append("<!DOCTYPE html>\n<html>\n<head>\n<meta charset=\"utf-8\"/>\n<head/>\n<body>\n");
            for (int i = 1; i < 15; i++)
            {
                int amount = 0;
                sb5032.Append("<p><b>" + i + "</b><p/>\n");
                Rectangle Rect1 = new Rectangle(100, 100, 100, 100);
                String Beginning = Rect1.Print1();
                String rel = "task5032\\test" + i + ".csv";
                try
                {
                    using (StreamReader str = new StreamReader(rel))
                    {
                        if (str.EndOfStream)
                        {
                            sb5032.Append("<p>Файл пуст<p/>");
                        }
                        else
                        {    
                            String err = "\nРезультат :";
                            while (!str.EndOfStream)
                            {
                                String[] s = str.ReadLine().Split(';');
                                if (s[0] == "shiftX" && s.Length == 2)
                                {
                                    if (Rect1.X + int.Parse(s[1]) < 0)
                                    {
                                        err = "\nОшибка: Координата X должна быть неотрицательной\nПоследнее корректное состояние:";
                                        break;
                                    }
                                    else
                                    {
                                        Rect1.X = Rect1.ShiftX(int.Parse(s[1]));
                                        amount++;
                                    }
                                }
                                else if (s[0] == "shiftY" && s.Length == 2)
                                {
                                    if (Rect1.Y + int.Parse(s[1]) < 0)
                                    {
                                        err = "\nОшибка: Координата Y должна быть неотрицательной\nПоследнее корректное состояние:";
                                        break;
                                    }
                                    else
                                    {
                                        Rect1.Y = Rect1.ShiftY(int.Parse(s[1]));
                                        amount++;
                                    }
                                }
                                else if (s[0] == "stretchX" && s.Length == 2)
                                {
                                    if (Rect1.W + int.Parse(s[1]) < 0)
                                    {
                                        err = "\nОшибка: Ширина должна быть положительной\nПоследнее корректное состояние:";
                                        break;
                                    }
                                    else
                                    {
                                        Rect1.W = Rect1.StretchX(int.Parse(s[1]));
                                        amount++;
                                    }
                                }
                                else if (s[0] == "stretchY" && s.Length == 2)
                                {
                                    if (Rect1.H + int.Parse(s[1]) < 0)
                                    {
                                        err = "\nОшибка: Высота должна быть положительной\nПоследнее корректное состояние:";
                                        break;
                                    }
                                    else
                                    {
                                        Rect1.H = Rect1.StretchY(int.Parse(s[1]));
                                        amount++;
                                    }
                                }
                                else
                                {
                                    err = "\nОшибка: Некорректный формат\nПоследнее корректное состояние:";
                                    break;
                                }
                            }
                            sb5032.Append("<p>Действий: " + amount + err + "<p/>");
                            sb5032.Append("<svg width=\"400\" height=\"400\">");
                            if (amount > 0)
                            {
                                sb5032.Append(Rect1.Print2());
                            }
                            sb5032.Append(Beginning);
                            sb5032.Append("\n</svg>\n</body>\n</html> ");
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    sb5032.AppendFormat($"Файл {Path.GetFullPath(rel)} не найден");
                }
                catch (FormatException ex)
                {
                    sb5032.Append("Не удается считать число");
                }
            }
            using (StreamWriter strw = new StreamWriter(result))
            {
                strw.WriteLine(sb5032);
            }
            System.Diagnostics.Process.Start(result);
        }
    }
}
