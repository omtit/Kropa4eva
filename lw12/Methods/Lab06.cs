using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab06
    {
        public static StringBuilder Task1862(StringBuilder sb1862, String s1, String s2, int w, int h)
        {
            if (w < 0)
            {
                throw new ArgumentException("Значение w должно быть неотрицательно");
            }
            if (h < 0)
            {
                throw new ArgumentException("Значение h должно быть неотрицательно");
            }
            if (h == 0 || w == 0)
            {
                sb1862.Append("");
            }
            else
            {
                int i = 1, j = 1;
                String a = "";
                while (i <= h)
                {

                    while (j <= w)
                    {
                        if (j % 2 == 0)
                        {
                            a = s2;
                        }
                        else
                        {
                            a = s1;
                        }
                        sb1862.Append(a);
                        j++;
                    }
                    sb1862.Append("\n");
                    j = 1;
                    i++;

                }
            }
            return sb1862;
        }
        public static StringBuilder Task5171(StringBuilder sb5172, String s1, String s2, int w, int h)
        {
            if (w < 0)
            {
                throw new ArgumentException("Значение w должно быть неотрицательно");
            }
            if (h < 0)
            {
                throw new ArgumentException("Значение h должно быть неотрицательно");
            }
            if (h == 0 || w == 0)
            {
                sb5172.Append("");
            }
            else
            {
                int i = 1, j = 1;
                String a = "";
                while (i <= h)
                {
                    if (i % 2 == 0)
                    {
                        a = s2;
                    }
                    else
                    {
                        a = s1;
                    }
                    while (j <= w)
                    {
                        sb5172.Append(a);
                        j++;
                    }
                    sb5172.Append("\n");
                    j = 1;
                    i++;
                }
            }
            return sb5172;
        }
        public static StringBuilder Task5238(StringBuilder sb5238, int w, int h)
        {
            if (w < 0)
            {
                throw new ArgumentException("Значение W должно быть неотрицательно");
            }
            if (h < 0)
            {
                throw new ArgumentException("Значение H должно быть неотрицательно");
            }
            if (h == 0 || w == 0)
            {
                sb5238.Append("");
            }
            else
            {
                int i = 1, j = 1, w1 = w;
                string a = "", d = "+", s = "#";
                while (j <= h)
                {
                    while (i <= w)
                    {
                        sb5238.Append(d);
                        i++;
                    }
                    w--;
                    i = 1;
                    sb5238.Append(a);
                    sb5238.Append("\n");
                    if (a.Length < w1)
                    {
                        a = a + s;
                    }
                    j++;
                }
            }
            return sb5238;

        }
        public static StringBuilder Task5448(StringBuilder sb5448, String s, int h)
        {
            if (h < 0)
            {
                throw new ArgumentException("Значение H должно быть неотрицательно");
            }
            if (h == 0)
            {
                sb5448.Append("");
            }
            else
            {
                String a = s;
                int i = 1;
                while (i <= h)
                {
                    sb5448.Append(s + "\n");
                    s = s + a;
                    i++;
                }
            }
            return sb5448;
        }
        public static StringBuilder Task7517(StringBuilder sb7517, int w, int h)
        {
            if (w < 0)
            {
                throw new Exception("Значение W должно быть неотрицательно");
            }
            if (h < 0)
            {
                throw new Exception("Значение H должно быть неотрицательно");
            }
            if (w == 0 || h == 0)
            {
                sb7517.Append("");
            }
            else
            {
                int i = 0, j = 0;
                sb7517.Append(" ");
                while (i <= w - 1)
                {
                    sb7517.Append(i);
                    i++;
                }
                i = 0;
                sb7517.Append("\n");
                while (j <= h - 1)
                {
                    sb7517.Append(j);
                    while (i <= w - 1)
                    {
                        sb7517.Append(" ");
                        i++;
                    }
                    sb7517.Append("|\n");
                    i = 0;
                    j++;
                }
                sb7517.Append(" ");
                while (i <= w - 1)
                {
                    sb7517.Append("-");
                    i++;
                }
            }
            return sb7517;

        }
        public static StringBuilder Task4075(StringBuilder sb4075, int w)
        {
            if (w < 0)
            {
                throw new ArgumentException("Значение W должно быть неотрицательно");
            }
            if (w == 0)
            {
                sb4075.Append("");
            }
            else
            {
                int i = 1;
                sb4075.Append("+");
                while (i <= w - 2)
                {
                    sb4075.Append("-");
                    i++;
                }
                sb4075.Append("+\n");
                i = 1;
                sb4075.Append("|");
                while (i <= w - 2)
                {
                    sb4075.Append(".");
                    i++;
                }
                sb4075.Append("|\n");
                i = 1;
                sb4075.Append("+");
                while (i <= w - 2)
                {
                    sb4075.Append("-");
                    i++;
                }
                sb4075.Append("+\n");
            }
            return sb4075;
        }
        public static StringBuilder Task2592(StringBuilder sb2592, String s, int w, int h)
        {
            if (w < 0)
            {
                throw new ArgumentException("Значение W должно быть неотрицательно");
            }
            if (h < 0)
            {
                throw new ArgumentException("Значение H должно быть неотрицательно");
            }
            if (h == 0 || w == 0)
            {
                sb2592.Append("");
            }
            else
            {
                int i = 1, j = 1;
                while (j <= h)
                {
                    while (i <= w)
                    {
                        sb2592.Append(s);
                        i++;
                    }
                    i = 1;
                    sb2592.Append("\n");
                    j++;
                }
            }
            return sb2592;
        }
        public static StringBuilder Task5568(StringBuilder sb5568, int w)
        {
            if (w < 0 || w > 20)
            {
                throw new Exception("Значение W должно быть в интервале [0, 20]");
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    sb5568.Append(i);
                }
                sb5568.Append("\n");
            }
            return sb5568;
        }
        public static StringBuilder Task8395(StringBuilder sb8395, int w)
        {
            if (w < 0 || w > 20)
            {
                throw new Exception("Значение W должно быть в интервале [0, 20]");
            }
            String[] s = { "a", "b", "c", "d", "e", "f", "g", "h" };
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    sb8395.Append(s[i]);
                }
                sb8395.Append("\n");
            }
            return sb8395;
        }
        public static StringBuilder Task4236(StringBuilder sb4236, int y)
        {
            if (y < 0 || y > 15)
            {
                throw new Exception("Значение Y должно быть в интервале [0, 15]");
            }
            for (int x = 0; x < 15; x++)
            {
                if (x < y)
                {
                    sb4236.Append("#");
                }
                else
                {
                    sb4236.Append(".");
                }
            }
            return sb4236;
        }
        public static StringBuilder Task3983(StringBuilder sb3983, int n)
        {
            if (n < 0)
            {
                throw new Exception("Значение N должно быть неотрицательным");
            }
            for (int i = 1; i <= n; i++)
            {
                if (i % 20 != 0)
                {
                    sb3983.Append("#");
                }
                else
                {
                    sb3983.Append(" ");
                }
            }
            return sb3983;
        }
        public static StringBuilder Task1483(StringBuilder sb1483, int n)
        {
            if (n < 0)
            {
                throw new Exception("Значение N должно быть неотрицательным");
            }
            for (int i = 1; i <= n; i++)
            {
                if (i % 5 != 0)
                {
                    sb1483.Append("!");
                }
                else
                {
                    sb1483.Append("! ");
                }
            }
            return sb1483;
        }
        public static StringBuilder Task2594(StringBuilder sb2594, int a, String b)
        {
            if (a < 0)
            {
                throw new ArgumentException("Значение A должно быть неотрицательным");
            }
            sb2594.Append("\"");
            for (int i = 0; i < a; i++)
            {
                sb2594.Append(b);
            }
            sb2594.Append("\"");
            return sb2594;
        }
        public static StringBuilder Task6066(StringBuilder sb6066, int a, int b)
        {
            if (a > b)
            {
                throw new Exception("Значение A должно быть не больше значения B");
            }
            while (a <= b)
            {
                sb6066.Append(a + "\n");
                a++;
            }

            return sb6066;
        }
        public static StringBuilder Task2565(StringBuilder sb2565, int a, int b)
        {
            if (a > b)
            {
                throw new Exception("Значение A должно быть не больше значения B");
            }
            while (b >= a)
            {
                sb2565.Append(b + " ");
                b--;
            }
            return sb2565;
        }
        public static bool Task5170(int y)
        {
            if (y <= 0)
            {
                throw new ArgumentException("Значение Y должно быть положительным");
            }
            int a = 0;
            for (int i = 1; i <= y; i++)
            {
                if (y % i == 0)
                {
                    a++;
                }
            }
            return a <= 2;
        }
        public static int Task1544(int B)
        {
            if (B < -10 || B > 10000)
            {
                throw new ArgumentException("Значение B должно быть в интервале [-100, 500]");
            }
            int sum = 0;
            while (B >= -10)
            {
                sum += B;
                B--;
            }
            return sum;
        }

        public static int Task9180(int A)
        {
            if (A < -100 || A > 500)
            {
                throw new ArgumentException("Значение A должно быть в интервале [-100, 500]");
            }
            int sum = 0;
            while (A <= 500)
            {
                sum += A;
                A++;
            }
            return sum;
        }
        public static double Task2802(double n)
        {
            if (n <= 0)
            {
                throw new Exception("Значение N должно быть положительным");
            }
            double i = 1, res = 0;
            while (i <= n)
            {
                res += 1 / i;
                i++;
            }
            return res;
        }
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

