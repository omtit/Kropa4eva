using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Methods
{
    public class Lab02
    {
        
        //public static String Task6882(int a)
        //{
        //    String rel = "task6882\\test" + a + ".txt";
        //    if (!File.Exists(rel))
        //    {
        //        throw new Exception("Файл"+ Path.GetFullPath(rel)+ "не найден");
        //    }
        //    return "task6882\\test" + a + ".txt";
        //}
        public static double Task3943(double x, double y)
        {
            if (y<0)
            {
                throw new Exception("Значение y должно быть неотрицательным");
            }
            if (x + Math.Sqrt(y)<0)
            {
                throw new Exception("Подкоренное выражение должно быть неотрицательным");
            }
            return -5 * Math.Sqrt(x + Math.Sqrt(y));
        }
        public static double Task7237(double x)
        {
            double y = -273.15;
            if (x < y)
            {
                throw new Exception("Температура должна быть выше абсолютного нуля");
            }
            return x * 1.8 + 32;
        }
        public static double Task4411(double x)
        {
            return x + 7;
        }

        public static double Task8428(double a)
        {
            return a * Math.PI / 180;
        }

        public static double Task1262(double a)
        {
            return 5 * Math.Cos(Task8428(a));
        }

        public static double Task2790(double a)
        {
            return Math.Sqrt(1 - Math.Pow(Math.Sin(Task8428(a)), 2));
        }

        public static double Task7711(int a)
        {
            return Math.Sin(a * Math.PI / 180);
        }

        public static int Task3832(int x1, int x2, int x3)
        {
            return x1 * x2 + x1 * x3 + x2 * x3;
        }

        public static double Task9354(double a, double b, double c)
        {
            if (a == 0 || b == 0 || c == 0)
            {
                throw new Exception("Данное уравнение не является квадратным");
            }
            else
            {
                return Math.Pow(b, 2) - 4 * a * c;
            }
        }

        public static double Task7457(double a)
        {
            return 7 * Math.Pow(a, 2) - 3 * a + 6;
        }

        public static double Task9865(double a)
        {
            return 12 * Math.Pow(a, 2) + 7 * a - 16;
        }

        public static double Task3558(double aInGrad, double bInGrad)
        {
            return 3 * Math.Sin(2 * Math.PI * aInGrad / 180) * Math.Cos(3 * Math.PI * bInGrad / 180);
        }

        public static double Task4366(double x1, double x2)
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(x2, 2));
        }
        public static double Task5895(double a, double b, double cInGrad)
        {
            if (Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(cInGrad * Math.PI / 180) < 0)
            {
                throw new Exception("Подкоренное выражение отрицательно");
            }
            else
            {
                return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) - 2 * a * b * Math.Cos(cInGrad * Math.PI / 180));
            }
        }

        public static double Task9164(int a, int b)
        {
            return Math.Sin(Task8428(a)) * Math.Cos(Task8428(b)) + Math.Cos(Task8428(a)) * Math.Sin(Task8428(b));
        }
        public static double Task5789(double xa, double ya, double xb, double yb)
        {
            return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
        }
        public static int Task5063(int a)
        {
            return a % 360;
        }
        public static double Task9020(int x)
        {
            if (x > 61)
            {
                throw new Exception("Подкоренное выражение должно быть неотрицательным");
            }
            return 3 * Math.Sqrt(61 - x);
        }
    }
}
