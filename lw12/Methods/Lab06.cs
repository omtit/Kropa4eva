using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab06
    {
        public static String Task2324(String a)
        {
            string[] arr = a.Split(' ');
            int sum = 0, count = 0, i = 0;
            int ai = int.Parse(arr[0]);
            do
            {
                ai = int.Parse(arr[i]);
                sum += ai;
                count++;
                i++;
            }
            while (ai != 0);
            return String.Format("Сумма чисел: {0}, Количество чисел: {1}", sum, count);
        }

        public static String Task4082(String a)
        {
            string[] arr = a.Split(' ');
            double b = 83, c = 199, countleft = 0, countright = 0, ai = 0;
            int i = 0;
            while (ai <= b || ai >= c)
            {
                ai = double.Parse(arr[i]);
                i++;
                if (ai <= b || ai >= c)
                {
                    if (ai >= c)
                    {
                        countright++;
                    }
                    if (ai <= b)
                    {
                        countleft++;
                    }
                }
            }
            return String.Format("Количество слева: {0}, Количество справа: {1}", countleft, countright);
        }
        public static int Task8731(String a)
        {
            string[] arr = a.Split(' ');
            int sum = 0, count = 0;
            while (sum <= 1000)
            {
                int ai = int.Parse(arr[count]);
                sum += ai;
                count++;
            }
            return count;
        }
        public static double Task5969(double a, double b)
        {
            double sum = 0;
            if (a > b)
            {
                while (a >= b)
                {
                    if (a % 7 == 0)
                    {
                        sum += a;
                    }
                    a--;
                }
            }
            else
            {
                while (a <= b)
                {
                    if (a % 7 == 0)
                    {
                        sum += a;
                    }
                    a++;
                }
            }
            return sum;
        }
        public static double Task6580(double a, double b)
        {
            double res = 0;
            if (a > b)
            {
                while (b <= a)
                {
                    res += Math.Pow(a, 2);
                    a--;
                }
            }
            else
            {
                while (a <= b)
                {
                    res += Math.Pow(a, 2);
                    a++;
                }
            }
            return res;
        }
        public static int Task8731(String[] b, int a)
        {
            int i = 0;
            int sum = 0;
            int count = 0;
            while (sum <= 1000)
            {
                a = int.Parse(b[i]);
                sum += a;
                count++;
                i++;

            }
            return count;
        }
        public static int Task9562(int a, int b)
        {
            int sum = 0;
            if (a > b)
            {
                while (b <= a)
                {
                    sum += a;
                    a--;
                }
            }
            else
            {
                while (a <= b)
                {
                    sum += a;
                    a++;
                }
            }
            return sum;
        }
        public static long Task3669(int a, int b)
        {
            long x = 1;
            if (a < b)
            {
                while (a <= b)
                {
                    x = x * a;
                    a++;
                }
            }
            else
            {
                while (b <= a)
                {
                    x = x * b;
                    b++;
                }
            }
            return x;
        }

        public static StringBuilder Task8495(StringBuilder sb)
        {
            int i = 0;
            while (i < 13)
            {
                sb.Append("!");
                i++;
            }
            return sb;
        }

        public static StringBuilder Task1315(StringBuilder sb)
        {
            for (int i = 17; i < 48; i++)
            {
                sb.Append(i + " ");
            }
            return sb;
        }
        public static StringBuilder Task2475()
        {
            int sum = 0;
            StringBuilder sb2475 = new StringBuilder();
            sb2475.Append("Ход решения: ");
            for (int i = 100; i < 501; i++)
            {

                sum += i;
                sb2475.Append(sum + " ");
            }
            sb2475.AppendFormat("\nОтвет: {0}", sum);
            return sb2475;

        }
    }
}

