using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab07
    {

        public static String Task2166(String b)
        {
            String a = "abcdacadbacdaabaadc";           
            if (b.Length != 2)
            {
               throw new ArgumentException("Вводимая строка должна содержать ровно 2 символа");
            }            
             return a.Replace(b, " ");
        }
        public static String Task7222(String a)
        {
            if (a.Length != 13)
            {
                throw new ArgumentException("Некорректная длина штрих-кода");
            }
            string a1 = a.Substring(0, 2);
            string a2 = a.Substring(3, 3);
            string a3 = a.Substring(7, 4);
            string a4 = a.Substring(12, 1);
            return String.Format("Код страны: {0}\nКод изготовителя: {1}\nКод товара: {2}\nКонтрольное число: {3}\n", a1, a2, a3, a4);
        }
        public static String Task4845(int ca, int cb)
        {
            String a = "abcdefwxyz";
            if (ca < 0 || ca > a.Length)
            {
                throw new ArgumentException("Значение CA должно быть в интервале [0,длина строки)");
            }
            if (cb < 0 || cb > a.Length)
            {
                throw new ArgumentException("Значение CB должно быть в интервале [0,длина строки)");
            }
            if (ca > cb)
            {
                throw new Exception("Значение CA должно быть меньше CB");
            }
            return a.Substring(ca, cb - ca + 1);
        }
        public static void Task1618(String a)
        {
            int j = 0;
            string str = "";
            for (int i = 0; i <= a.Length - 1; i++)
            {
                string c = a.Substring(i, 1);
                if (c == "{")
                {
                    j++;
                }
                if (c == "}")
                {
                    j--;
                }
                if (j < 0)
                {
                    str = str + " Неожиданный символ '}'";
                    break;
                }
                else
                {
                    str = str + j;
                }
            }

            if (j != 0 && !str.EndsWith("'"))
            {
                str = str + " Неожиданный конец строки";
            }
            Console.WriteLine(a);
            Console.WriteLine(str);
        }

        public static String Task9116(String b)
        {
            if (!b.StartsWith("\"") || !b.EndsWith("\""))
            {
                throw new Exception("Строка должна начинаться и заканчиваться кавычкой");
            }
            return b.Trim(' ', '"');
        }

        public static String Task5923(int ca, int cb)
        {
            String b = "abcdefwxyz";
            if (ca + cb > b.Length)
            {
                throw new Exception("Сумма значений CA и CB должна быть меньше длины строки");
            }
            if (ca < 0 || ca > b.Length)
            {
                throw new Exception("Значение CA должно быть в интервале [0, длина строки)");
            }
            if (cb < 0)
            {
                throw new Exception("Значение CB должно быть неотрицательно");
            }
            return b.Remove(ca, cb);
        }

        public static String Task5728(String ca, String cb)
        {
            String b = "abcdefwxyz";
            if (b.IndexOf(ca) == -1)
            {
                throw new Exception("Значение CA отсутсвует в строке");
            }
            if (b.IndexOf(cb) == -1)
            {
                throw new Exception("Значение CB отсутсвует в строке");
            }
            if (b.IndexOf(ca) > b.IndexOf(cb))
            {
                return b.Substring(b.IndexOf(cb) + 1, b.IndexOf(ca) - b.IndexOf(cb) - 1);
            }
            else
            {
                return b.Substring(b.IndexOf(ca) + 1, b.IndexOf(cb) - b.IndexOf(ca) - 1);
            }
        }
        public static int Task9812(String ca, String cb)
        {
            String b = "abcdefwxyz";
            if (b.IndexOf(ca) == -1)
            {
                throw new Exception("Значение CA отсутсвует в строке");
            }
            if (b.IndexOf(cb) == -1)
            {
                throw new Exception("Значение CB отсутсвует в строке");
            }
            if (b.IndexOf(ca) > b.IndexOf(cb))
            {
                return b.IndexOf(ca) - b.IndexOf(cb) - 1;
            }
            else
            {
                return b.IndexOf(cb) - b.IndexOf(ca) - 1;
            }
        }
        public static int Task9631(String a)
        {
            String b = "abcdefwxyz";
            if (b.IndexOf(a) == -1)
            {
                throw new Exception("Значение отсутсвует в строке");
            }
            return b.Length - b.IndexOf(a) - 1;
        }
        public static bool Task7491(String a)
        {
            String b = "abcdefwxyz";
            return b.IndexOf(a) != -1;
        }
        public static int Task9925(String a)
        {
            string[] arr = a.Split(',');
            return arr.Length;
        }
        public static String Task4265(String a)
        {
            string a1 = "U", a2 = "s";
            if (a.Substring(0, 1) == a1)
            {
                a = a.ToUpper();
            }
            if (a.Substring(0, 1) == a2)
            {
                a = a.ToLower();
            }
            return a;
        }
    }
}
