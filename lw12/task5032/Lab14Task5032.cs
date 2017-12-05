using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Classes.Form;

namespace task5032
{
    class Lab14Task5032
    {
        static void Main(string[] args)
        {
            StringBuilder sb5032 = new StringBuilder();
            Form F = new Form();
            F.Top(sb5032);
            for (int i = 1; i < 15; i++)
            {
                F.Mid1(sb5032, i);
                int amount = 0;
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
                            while (!str.EndOfStream)
                            {
                                String[] s = str.ReadLine().Split(';');
                                if (s[0] == "shiftX" && s.Length == 2)
                                {
                                    Rect1.ShiftX(int.Parse(s[1]));
                                    amount++;
                                }
                                else if (s[0] == "shiftY" && s.Length == 2)
                                {
                                    Rect1.ShiftY(int.Parse(s[1]));
                                    amount++;
                                }
                                else if (s[0] == "stretchX" && s.Length == 2)
                                {
                                    Rect1.StretchX(int.Parse(s[1]));
                                    amount++;
                                }
                                else if (s[0] == "stretchY" && s.Length == 2)
                                {
                                    Rect1.StretchY(int.Parse(s[1]));
                                    amount++;
                                }
                                else
                                {
                                    throw new ArgumentException("<p>\nОшибка: Некорретный формат данных\nПоследнее корректное состояние: <p/>");
                                }
                            }
                        }
                    }
                }
                catch (ArgumentException ex)
                {
                    sb5032.Append(ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    sb5032.AppendFormat($"Файл {Path.GetFullPath(rel)} не найден");
                }
                catch (FormatException ex)
                {
                    sb5032.Append("<p>Не удается считать число<p/>");
                }
                if (amount > 0)
                {
                    sb5032.Append("<p>Действий: " + amount + "<p/>");
                    F.CreaeI(sb5032);
                    sb5032.Append(Beginning);
                    sb5032.Append(Rect1.Print2());
                    F.CloseI(sb5032);
                }
            }
            F.Bot(sb5032);
        }
    }
}


