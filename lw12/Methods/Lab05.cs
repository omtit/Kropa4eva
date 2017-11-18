using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab05
    {

        public static bool Task2153(int t)
        {
            if (t < 0 || t > 59)
            {
                throw new ArgumentException("Значение T должно быть в интервале [0, 59]");
            }
            return t % 5 >= 0 && t % 5 < 3;
        }
        public static bool Task6556(int a, int b,int c ,int d)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Значение a должно быть неотрицательным");
            }
            if (b <= 0)
            {
                throw new ArgumentException("Значение b должно быть неотрицательным");
            }
            if (c <= 0)
            {
                throw new ArgumentException("Значение c должно быть неотрицательным");
            }
            if (d <= 0)
            {
                throw new ArgumentException("Значение d должно быть неотрицательным");
            }
            return ((a <= c && a <= d) || (b <= c && b <= d));            
        }
        public static String Task4527(int a)
        {
            if (a < -10 || a > 100)
            {
                throw new ArgumentException("Значение A должно быть в интервале [-10, 100]");
            }
            if ((a % 10 == 2 || a % 10 == -2 || a == 40 || a % 10 == 6 || a % 10 == -6 || a % 10 == 7 || a % 10 == -7 || a % 10 == 8 || a % 10 == -8) && a != 12 && a != 16 && a != 17 && a != 18)
            {
                return String.Format(a + "\'ой");
            }
            if ((a % 10 == 3 || a % 10 == -3) && a != 13)
            {
                return String.Format(a + "\'ий");
            }
            else
            {
                return String.Format(a + "\'ый");
            }
        }
        public static bool Task3883(int a)
        {
            if (a < 1000 || a > 9999)
            {
                throw new ArgumentException("Значение A должно быть в интервале [1000, 9999]");
            }
            int b = a % 10;
            int c = ((a - b) % 100) / 10;
            int d = ((a - b - c) % 1000) / 100;
            return b == d;
        }
        public static bool Task6291(int a, int b, int c)
        {
            if (a <= 0)
            {
                throw new ArgumentException("Значение a должно быть неотрицательным");
            }
            if (b <= 0)
            {
                throw new ArgumentException("Значение b должно быть неотрицательным");
            }
            if (c <= 0)
            {
                throw new ArgumentException("Значение c должно быть неотрицательным");
            }
            return a == b || b == c || a == c;
        }
        public static bool Task1945(int Sc, int Ss)
        {
            if (Sc <= 0)
            {
                throw new ArgumentException("Площадь круга должна быть положительной");
            }
            if (Ss <= 0)
            {
                throw new ArgumentException("Площадь квадрата должна быть положительной");
            }
            return 2 * Math.Sqrt(Sc / Math.PI) <= Math.Sqrt(Ss);
        }
        public static String Task1763(int r, int a)
        {
            if (r < 0)
            {
                throw new ArgumentException("Радиус должен быть положительным");
            }
            if (a < 0)
            {
                throw new ArgumentException("Сторона квадрата должнам быть положительной");
            }
            double s1 = Math.Pow(a, 2);
            double s2 = Math.Pow(r, 2) * Math.PI;
            if (s1 == s2)
            {
                return String.Format("Площади равны");
            }
            if (s1 > s2)
            {
                return String.Format("Площадь квардрата {0:F4} больше площади круга {1:F4}", s1, s2);
            }
            else
            {
                return String.Format("Площадь круга {1:F4} больше площади квадрата {0:F4}", s1, s2);
            }
        }
        public static String Task2291(double speed1, double speed2)
        {
            if (speed1 < 0)
            {
                throw new ArgumentException("Значение velocityInKmH должно быть неотрицательным");
            }
            if (speed2 < 0)
            {
                throw new ArgumentException("Значение velocityInMS должно быть неотрицательным");
            }
            double s = speed1 * 1000 / 3600;
            if (s > speed2)
            {
                return String.Format("{1:F2} м/c меньше {0:F2} км/ч", speed1, speed2);
            }
            else
            {
                return String.Format("{0:F2} км/ч меньше {1:F2} м/с", speed1, speed2);
            }
        }
        public static bool Task4257(double a, double b)
        {
            if (a < 0)
            {
                throw new ArgumentException("Значение L должно быть неотрицательным");
            }
            if (b < 0)
            {
                throw new ArgumentException("Значение P должно быть неотрицательным");
            }
            return a * 1000 < b * 0.305;
        }
        public static String Task7937(int W, int H, int C, int D)
        {
            if (W <= 0)
            {
                throw new ArgumentException("Значение W должно быть положительным");
            }
            if (H <= 0)
            {
                throw new ArgumentException("Значение H должно быть положительным");
            }
            if (C <= 0)
            {
                throw new ArgumentException("Значение C должно быть положительным");
            }
            if (D <= 0)
            {
                throw new ArgumentException("Значение D должно быть положительным");
            }
            int S1, S2, x1, y1, x2, y2;
            x1 = W / C;
            y1 = H / D;
            S1 = x1 * y1;
            x2 = W / D;
            y2 = H / C;
            S2 = x2 * y2;
            if (S1 > S2)
            {
                return String.Format(S1 + " при С вдоль W");
            }
            else
            {
                return String.Format(S2 + " при С вдоль H");
            }
        }
        public static StringBuilder Task8518(StringBuilder sb8518, String x)
        {
            String[] a = { "a", "b", "c", "d", "e", "f", "g", "h" };
            int i = 0;
            while (i < a.Length)
            {
                if (a[i] == x)
                {
                    sb8518.Append(a[i] + "+\n");
                }
                else
                {
                    sb8518.Append(a[i] + "\n");
                }
                i++;
            }
            return sb8518;
        }
        public static bool Task8878(int a, int b)
        {
            return a < b;
        }
        public static double Task5980(double k)
        {
            if (k <= 0)
            {
                return Math.Pow(k, 2);
            }
            else
            {
                return Math.Sqrt(k);
            }
        }

        public static double Task8174(double a)
        {
            if (a < 0)
            {
                return a * -1;
            }
            else
            {
                return a;
            }
        }

        public static String Task5662(double a, double b, double c)
        {
            if (a == 0)
            {
                return String.Format("Данное уравнение не является квадратным");
            }
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d == 0)
            {
                return String.Format("Уравнение " + a + "x^2 + " + b + "x +" + c + " имеет один корень.");
            }
            if (d < 0)
            {
                return String.Format("Вещественных корней уравнения " + a + "x^2 + " + b + "x + " + c + " нет.");
            }
            else
            {
                return String.Format("У уравнения " + a + "x^2 + " + b + "x + " + c + " = 0 два вещественных.");
            }
        }

        public static int Task3770(int x, int y, int z)
        {
            int a;
            if (x > y)
            {
                a = x;
            }
            else
            {
                a = y;
            }
            if (a > z)
            {
                return a;
            }
            else
            {
                return z;
            }
        }

        public static bool Task8715(int a, int b, int c)
        {
            return a < b && b < c;
        }

        public static bool Task1999(int x, int y)
        {
            return y >= 1 && x <= -2;
        }

        public static bool Task4042(double x, double y)
        {
            return y >= -2 && y <= 1.5;
        }
        public static bool Task4847(int x, int y, int z)
        {
            return x == y || x == z || y == z;
        }
        public static bool Task6351(double x, double y)
        {
            return y <= 4 && x >= 1 && x <= 2;
        }
        public static bool Task5382(double x, double y)
        {
            return (x > 1 && y >= 2 && y <= 4);
        }
        public static bool Task7088(double x, double y)
        {
            return (x >= 2 && y >= 0) || (x >= 1 && y <= -1);
        }
        public static bool Task7250(double x, double y)
        {
            return (x >= 2 && y >= 1) || (x >= 2 && y <= -1.5);
        }
        public static bool Task6740(double x, double y)
        {
            return (x >= 1 && y >= -2) || (x <= 3 && y <= -1);
        }
        public static bool Task9038(double x, double y)
        {
            return (x >= 2) || (x <= 2 && y >= 0.5 && y <= 1.5);
        }
    }
}
