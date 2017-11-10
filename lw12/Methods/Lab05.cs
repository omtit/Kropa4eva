using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab05
    {
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
