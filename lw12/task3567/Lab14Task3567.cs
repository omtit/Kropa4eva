using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task3567
{
    public class Lab14Task5032
    {
        static void Main(string[] args)
        {
            StringBuilder sb3567 = new StringBuilder();
            sb3567.Append("<!DOCTYPE html>\n<html>\n<head>\n<meta charset=\"utf-8\"/>\n<head/>\n<body>\n");
            String result = "res.html";
            for (int i = 1; i < 15; i++)
            {
                Circle Circle1 = new Circle(150, 150, 50);
                String Beginning = Circle1.Print1();
                String rel = "task3567\\test" + i + ".csv";
                try
                {
                    sb3567.Append("<p><b><u>" + i + "</u></b><p/>\n");
                    using (StreamReader str = new StreamReader(rel))
                    {
                        if (str.EndOfStream)
                        {
                            sb3567.Append("<p>Файл пуст\n<p/>");
                        }
                        else
                        {                            
                            int amount = 0;
                            String err = "\nРезультат :";
                            while (!str.EndOfStream)
                            {
                                String[] s = str.ReadLine().Split(';');

                                if (s[0] == "shiftX" && s.Length == 2)
                                {
                                    if (Circle1.X + int.Parse(s[1]) / 2 < 0)
                                    {
                                        err = "\nОшибка: Координата X должна быть неотрицательной\nПоследнее корректное состояние:";
                                        break;
                                    }
                                    else
                                    {
                                        Circle1.X = Circle1.ShiftX(int.Parse(s[1]));
                                        amount++;
                                    }
                                }

                                else if (s[0] == "shiftY" && s.Length == 2)
                                {
                                    if (Circle1.Y + int.Parse(s[1]) / 2 < 0)
                                    {
                                        err = "\nОшибка: Координата Y должна быть неотрицательной\nПоследнее корректное состояние:";
                                        break;
                                    }
                                    else
                                    {
                                        Circle1.Y = Circle1.ShiftY(int.Parse(s[1]));
                                        amount++;
                                    }
                                }

                                else if (s[0] == "stretchX" && s.Length == 2)
                                {
                                    if (Circle1.R + int.Parse(s[1]) / 2 < 0)
                                    {
                                        err = "\nОшибка: Ширина должна быть положительной.\nПоследнее корректное состояние:";
                                        break;
                                    }
                                    if (Circle1.Y - int.Parse(s[1]) / 2 - Circle1.R < 0)
                                    {
                                        err = "\nОшибка: Верхняя точка круга должна иметь неотрицательные координаты.\nПоследнее корректное состояние:";
                                        break;
                                    }
                                    else
                                    {
                                        Circle1.StretchX(int.Parse(s[1]));
                                        amount++;
                                    }
                                }
                                else if (s[0] == "stretchY" && s.Length == 2)
                                {
                                    if (Circle1.R + int.Parse(s[1]) / 2 < 0)
                                    {
                                        err = "\nОшибка: Высота должна быть положительной.\nПоследнее корректное состояние:";
                                        break;
                                    }
                                    if (Circle1.X - int.Parse(s[1]) / 2 - Circle1.R < 0)
                                    {

                                        err = "\nОшибка: Левая точка круга должна иметь неотрицательные координаты.\nПоследнее корректное состояние:";
                                        break;
                                    }
                                    else
                                    {
                                        Circle1.StretchY(int.Parse(s[1]));
                                        amount++;
                                    }
                                }
                                else
                                {
                                    err = "\nОшибка: Некорректный формат\nПоследнее корректное состояние:";
                                    break;
                                }

                            }
                            sb3567.Append("<p>Действий: " + amount + err + "<p/>");
                            sb3567.Append("<svg width=\"400\" height=\"400\">");
                            if (amount > 0)
                            {
                                sb3567.Append(Circle1.Print2());
                            }
                            sb3567.Append(Beginning);
                            sb3567.Append("\n</svg>\n</body>\n</html> ");
                        }
                    }
                }
                catch (FileNotFoundException ex)
                {
                    sb3567.AppendFormat($"Файл {Path.GetFullPath(rel)} не найден");
                }
                catch (FormatException ex)
                {
                    sb3567.Append("Не удается считать число");
                }
            }
            using (StreamWriter strw = new StreamWriter(result))
            {
                strw.WriteLine(sb3567);
            }
            System.Diagnostics.Process.Start(result);
        }
    }
}
