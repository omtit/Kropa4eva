using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Methods
{
    public class Lab02
    {

        public static double Task7799(int mass, int aInGrad)
        {
            if (mass <= 0)
            {
                throw new Exception("Масса должна быть положительной");
            }
            double g = 9.8067;
            if (aInGrad % 360 <= 90)
            {
                return mass * g * Math.Cos(Task8428(aInGrad));
            }
            else
            {
                return mass * g * Math.Cos(Task8428(180 - aInGrad));
            }
        }
        public static double Task2461(double a, double b, double c, double d)
        {
            if (a == 0)
            {
                throw new Exception("Значение a должно быть не равно нулю");
            }
            if (d == 0)
            {
                throw new Exception("Значение b должно быть не равно нулю");
            }
            return (a * d + b * c) / a / d;
        }
            
        public static double Task9130(double mass1, double mass2, double dist)
        {
            double g = 9.8067;
            if (mass1 <= 0 || mass2 <= 0)
            {
                throw new Exception("Масса должна быть положительной");
            }
            if (dist <= 0)
            {
                throw new Exception("Дистанция должна быть неотрицательной");
            }
            return g * mass1 * mass2 / Math.Pow(dist, 2);
        }
        public static double Task7619(double speed1, double speed2, double dist)
        {
            if (speed1 < 0)
            {
                throw new Exception("Значение v1 должно быть неотрицательным");
            }
            if (speed2 < 0)
            {
                throw new Exception("Значение v2 должно быть неотрицательным");
            }
            if (dist < 0)
            {
                throw new Exception("Расстояние должно быть неотрицательным");
            }
            return dist / (speed1 + speed2);
        }

        public static double Task1934(double a, double b)
        {
            if (b > 0)
            {
                throw new ArgumentException("Значение B должно быть не положительным");
            }
            return a * Math.Sqrt(-7 * b);
        }
        public static double Task8833(double x)
        {
            if (x < 0)
            {
                throw new ArgumentException("Значение X должно быть неотрицательным");
            }
            return Math.Sqrt(x);
        }
        public static double Task4312(double b, double h)
        {
            if (b <= 0)
            {
                throw new ArgumentException("Значение base должно быть положительным");
            }
            if (h <= 0)
            {
                throw new ArgumentException("Значение height должно быть положительным");
            }
            return b * h / 2;
        }
        public static double Task2981(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным");
            }
            return 4 * Math.PI * Math.Pow(r, 3) / 3;
        }
        public static double Task5201(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным");
            }
            return 2 * Math.PI * r;
        }

        public static int Task3354(int edge)
        {
            if (edge <= 0)
            {
                throw new Exception("Значение edge должно быть положительным");
            }
            return edge * edge * edge;
        }
        public static int Task9298(int edge)
        {
            if (edge <= 0)
            {
                throw new Exception("Значение edge должно быть положительным");
            }
            return 6 * edge * edge;
        }
        public static double Task3591(double x)
        {
            int r = 6350;
            if (x < 0)
            {
                throw new ArgumentException("Высота над уровнем Земли должна быть неотрицательна");
            }
            return Math.Sqrt(Math.Pow(r + x, 2) - Math.Pow(r, 2));
        }
        public static double Task5871(double x)
        {
            if (x < 5)
            {
                throw new Exception("Подкоренное выражение должно быть неотрицательным");
            }

            return (Math.Sqrt(x + 5) + Math.Sqrt(x - 5)) / (2 * Math.Sqrt(x));
        }

        public static double Task1346(double speedat0, double time, double acc)
        {
            if (speedat0 < 0)
            {
                throw new ArgumentException("Начальная скорость должнa быть неотрицательна");

            }
            if (time <= 0)
            {
                throw new ArgumentException("Время должно быть положительным");
            }
            return speedat0 * time + acc * Math.Pow(time, 2) / 2;

        }
        public static double Task2624(double a, double b, double c, double x)
        {
            double koren = a * Math.Pow(x, 2) + b * x + c;
            if (koren < 0)
            {
                throw new Exception("Подкоренное выражение должно быть неотрицательным");

            }
            if (koren == 0)
            {
                throw new Exception("Знаменатель не может быть равен нулю");
            }
            return 1 / Math.Sqrt(koren);
        }

        public static double Task8873(double r1, double r2)
        {
            if (r1 == 0)
            {
                throw new Exception("Значение r1 должно быть не равно нулю");
            }
            if (r2 == 0)
            {
                throw new Exception("Значение r2 должно быть не равно нулю");
            }
            return 1 / r1 + 1 / r2;
        }

        public static double Task3943(double x, double y)
        {
            if (y < 0)
            {
                throw new Exception("Значение y должно быть неотрицательным");
            }
            if (x + Math.Sqrt(y) < 0)
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
        //public static String Task6882(int a)
        //{
        //    String rel = "task6882\\test" + a + ".txt";
        //    if (!File.Exists(rel))
        //    {
        //        throw new Exception("Файл"+ Path.GetFullPath(rel)+ "не найден");
        //    }
        //    return "task6882\\test" + a + ".txt";
        //}
    }
}
