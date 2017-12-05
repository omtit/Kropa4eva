using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Classes.Form;

namespace task3567
{
    public class Lab14Task5032
    {
        static void Main(string[] args)
        {
            StringBuilder sb3567 = new StringBuilder();
            Form F = new Form();
            F.Top(sb3567);
            for (int i = 1; i < 15; i++)
            {
                F.Mid1(sb3567,i);
                int amount = 0;
                Circle Circle1 = new Circle(150, 150, 100);
                String Beginning = Circle1.Print2();
                String rel = "task3567\\test" + i + ".csv";
                try
                {                   
                    using (StreamReader str = new StreamReader(rel))
                    {
                        if (str.EndOfStream)
                        {
                            sb3567.Append("<p>Файл пуст\n<p/>");
                        }
                        else
                        { 
                            while (!str.EndOfStream)
                            {
                                String[] s = str.ReadLine().Split(';');

                                if (s[0] == "shiftX" && s.Length == 2)
                                {
                                    Circle1.ShiftX(int.Parse(s[1]));
                                    amount++;
                                }
                                else if (s[0] == "shiftY" && s.Length == 2)
                                {
                                    Circle1.ShiftY(int.Parse(s[1]));
                                    amount++;
                                }
                                else if (s[0] == "stretchX" && s.Length == 2)
                                {
                                    Circle1.StretchX(int.Parse(s[1]));
                                    amount++;
                                }
                                else if (s[0] == "stretchY" && s.Length == 2)
                                {
                                    Circle1.StretchY(int.Parse(s[1]));
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
                    sb3567.Append(ex.Message);
                }
                catch (FileNotFoundException ex)
                {
                    sb3567.AppendFormat($"Файл {Path.GetFullPath(rel)} не найден");
                    continue;
                }
                catch (FormatException ex)
                {
                    sb3567.Append("Не удается считать число");
                }
                sb3567.Append("<p>Действий: " + amount + "<p/>");
                F.CreaeI(sb3567);
                sb3567.Append(Beginning);
                if (amount > 0)
                {
                    sb3567.Append(Circle1.Print1());                    
                }
                F.CloseI(sb3567);
            }
            F.Bot(sb3567);
        }
    }
}
