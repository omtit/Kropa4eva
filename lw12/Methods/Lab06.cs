using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab06
    {
        public static StringBuilder Task8770(StringBuilder sb8770, int x)
        {
            for (int n = 30; n <= 40; n++)
            {
                if (x == n)
                {
                    sb8770.Append(x + "+\n");
                }
                else
                {
                    sb8770.Append(n + "-\n");
                }
            }
            return sb8770;
        }

        public static StringBuilder Task7585(StringBuilder sb7585, int x)
        {
            for (int n = 10; n <= 20; n++)
            {
                if (x == n)
                {
                    sb7585.Append(x + "+\n");
                }
                else
                {
                    sb7585.Append(n + "\n");
                }
            }
            return sb7585;
        }

        public static StringBuilder Task5411(StringBuilder sb5411, int p, int q)
        {
            int a = (p + q) / 2, q1 = q, p1 = p;
            if (p < q)
            {
                while (p < a)
                {
                    sb5411.Append(p + "<");
                    p++;
                }
                while (a <= (q - 1))
                {
                    sb5411.Append(p + ">");
                    q--;
                    p++;
                }
                sb5411.Append(q1);
            }
            else
            {
                while (q < a)
                {
                    sb5411.Append(q + "<");
                    q++;
                }
                while (a <= (p - 1))
                {
                    sb5411.Append(q + ">");
                    p--;
                    q++;
                }
                sb5411.Append(p1);
            }
            return sb5411;
        }
        public static StringBuilder Task2084(StringBuilder sb2084, int a, int b)
        {
            if (a < b)
            {
                if (a % 2 != 0)
                {
                    sb2084.Append(a);
                }
                while (a < (b - 1))
                {
                    if (a % 2 == 0)
                    {
                        sb2084.Append(a + 1);
                    }
                    else
                    {
                        sb2084.Append(",");
                    }
                    a++;
                }
                if (b % 2 != 0)
                {
                    sb2084.Append(b);
                }
                else
                {
                    sb2084.Append("");
                }
            }
            else
            {
                if (a % 2 != 0)
                {
                    sb2084.Append(a);
                }
                while ((b + 1) < a)
                {
                    if (a % 2 == 0)
                    {
                        sb2084.Append(a - 1);
                    }
                    else
                    {
                        sb2084.Append(",");
                    }
                    a--;
                }
                if (b % 2 != 0)
                {
                    sb2084.Append(b);
                }
            }
            return sb2084;
        }
        public static StringBuilder Task6572(StringBuilder sb6572, int a, int b)
        {
            String c = "", s = ".";
            if (a > b)
            {
                while (b <= a)
                {
                    if (b % 2 != 0)
                    {
                        sb6572.Append(c);
                        sb6572.AppendFormat("{0}\n", b);
                        c = c + s;
                    }
                    b++;
                }
            }
            else
            {
                while (a <= b)
                {
                    if (a % 2 != 0)
                    {
                        sb6572.Append(c);
                        sb6572.AppendFormat("{0}\n", a);
                        c = c + s;
                    }
                    a++;
                }
            }
            return sb6572;
        }
        public static StringBuilder Task3550(StringBuilder sb3550)
        {
            int x, i = 1;
            while (i <= 9)
            {
                x = i * 7;
                sb3550.AppendFormat("{0} x 7 = {1}\n", i, x);
                i++;
            }
            return sb3550;
        }
        public static StringBuilder Task3762(StringBuilder sb3762)
        {
            int w, i = 1, x = 453;
            while (i <= 20)
            {
                w = i * x;
                sb3762.AppendFormat("{0}     {1}\n", i, w);
                i++;
            }
            return sb3762;
        }
        public static StringBuilder Task8696()
        {
            StringBuilder sb8696 = new StringBuilder();
            int x = 0, n = 100, m = 1000;
            while (n <= m)
            {
                if (n % 13 != 0)
                {
                    sb8696.Append(n + " ");
                }
                else
                {
                    sb8696.Append(n + "+ ");
                    x++;
                }
                n++;
            }
            sb8696.AppendFormat("\nОтвет: {0}", x);
            return sb8696;
        }
        public static StringBuilder Task5951()
        {
            double sum = 0, c = 0, a = 20, b = 40;
            StringBuilder sb5951 = new StringBuilder();
            sb5951.Append("Ход решения: 0 + ");
            while (a <= b)
            {
                c = Math.Pow(a, 3);
                sb5951.Append(sum + "+" + c + "=");
                sum += c;
                a++;
            }
            sb5951.AppendFormat("\nОтвет: {0}", sum);
            return sb5951;
        }
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

