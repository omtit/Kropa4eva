using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

    public class Lab08
    {
        public static String Task5683(String a)
        {
            String[] a1 = a.Split(' ');
            StringBuilder sb5683 = new StringBuilder();
            if (a.Length == 0)
            {
                sb5683.Append("");
            }
            else
            {
                int i = 0;
                while (i < a1.Length)
                {
                    sb5683.Append(a1[i] + " " + i + "\n");
                    i++;
                }
            }
            return sb5683.ToString();
        }
        public static int Task8769(int p, int q, String s1)
        {
            if (String.IsNullOrEmpty(s1))
            {
                throw new Exception("Сообщение об ошибке");
            }

            if (p < 0 || q < 0 || p > s1.Length - 1 || q > s1.Length - 1)
            {
                throw new Exception("Сообщение об ошибке");
            }
            int k = 0;
            String[] a1 = s1.Split(' ');
            if (p < q)
            {
                k = int.Parse(a1[p]);
                while (p < q)
                {
                    int a22 = int.Parse(a1[p + 1]);
                    if (k > a22)
                    {
                        k = a22;
                    }
                    p++;
                }
            }
            else
            {
                k = int.Parse(a1[q]);
                while (q < p)
                {
                    int a22 = int.Parse(a1[q + 1]);
                    if (k > a22)
                    {
                        k = a22;
                    }
                    q++;
                }
            }
            return k;
        }
        public static int Task7290(int b, String s1)
        {
            if (String.IsNullOrEmpty(s1))
            {
                Console.WriteLine("Исходная строка пуста");
            }
            String[] a1 = s1.Split(' ');
            if (b < 0 || b > a1.Length - 1)
            {
                throw new Exception("Число B должно быть в интервале [0, размер массива)");
            }
            int amount = 0;
            int b1 = int.Parse(a1[b]);
            for (int i = 0; i < b; i++)
            {
                int a2 = int.Parse(a1[i]);
                if (a2 < b1)
                {
                    amount++;
                }
            }
            for (int i = b + 1; i < a1.Length; i++)
            {
                int a2 = int.Parse(a1[i]);
                if (a2 < b1)
                {
                    amount++;
                }
            }
            return amount;
        }
        public static String Task4425(int a, String str)
        {
            if (String.IsNullOrEmpty(str))
            {
                throw new ArgumentException("Исходная строка пуста");
            }
            String[] arr = str.Split(' ');
            if (a > arr.Length || a < 0)
            {
                throw new Exception("Число A должно быть в интервале [0, размер массива)");
            }
            return arr[a];
        }
        public static int Task5894(String s1, String s2)
        {
            if (String.IsNullOrEmpty(s1))
            {
                throw new ArgumentException("Данные сверху отсутствуют");
            }
            if (String.IsNullOrEmpty(s2))
            {
                throw new ArgumentException("Данные слева отсутствуют");
            }
            String[] a1 = s1.Split(' ');
            String[] a2 = s2.Split(' ');
            int i = 0, j = 0, amount = 0;
            while (j < a1.Length)
            {
                i = 0;
                while (i < a2.Length)
                {
                    if (a1[j] == a2[i])
                    {
                        amount++;
                    }
                    i++;
                }
                j++;
            }
            return amount;
        }
        public static StringBuilder Task6806(StringBuilder sb6806, int b)
        {
            int[] a = { 11, 13, 17, 19, 10, 12, 14, 15, 16, 18, 20 };
            int i = 0;
            while (i < a.Length)
            {
                if (a[i] == b)
                {
                    sb6806.Append(a[i] + "+\n");
                }
                else
                {
                    sb6806.Append(a[i] + "\n");
                }
                i++;
            }
            return sb6806;
        }
        public static StringBuilder Task5694(StringBuilder sb5694, String x)
        {
            String[] a = { "a", "b", "c", "d", "e", "f", "g", "h" };
            int i = 0;
            while (i < a.Length)
            {
                if (a[i] == x)
                {
                    sb5694.Append(a[i] + "+\n");
                }
                else
                {
                    sb5694.Append(a[i] + "\n");
                }
                i++;
            }
            return sb5694;
        }
        public static String Task7035(String s1)
        {
            if (String.IsNullOrEmpty(s1))
            {
                return String.Format("Данные отсутствуют");
            }
            StringBuilder sb7035 = new StringBuilder();
            String[] a1 = s1.Split(' ');
            int k = int.Parse(a1[0]);
            sb7035.AppendFormat("Ход решения:\nНачинаю с {0}\n", a1[0]);
            for (int i = 1; i < a1.Length; i++)
            {
                int a2 = int.Parse(a1[i]);
                sb7035.AppendFormat("Сравниваю {0} и {1}\n", k, a2);
                if (a2 < k)
                {
                    k = a2;
                    sb7035.AppendFormat("Заменяю\n");
                }
            }
            sb7035.AppendFormat("Ответ: {0}", k);
            return sb7035.ToString();
        }
        public static String Task7369(String s1, String s2)
        {
            if (String.IsNullOrEmpty(s1))
            {
                return String.Format("Данные сверху отсутствуют");
            }
            if (String.IsNullOrEmpty(s2))
            {
                return String.Format("Данные слева отсутствуют");
            }
            StringBuilder sb7369 = new StringBuilder();
            String[] a1 = s1.Split(' ');
            String[] a2 = s2.Split(' ');
            int i = 0, j = 0;
            sb7369.AppendFormat("  {0}\n", s1);
            while (j < a2.Length)
            {
                i = 0;
                sb7369.AppendFormat("{0} ", a2[j]);
                while (i < a1.Length)
                {
                    if (a2[j] == a1[i])
                    {
                        sb7369.Append("+ ");
                    }
                    else
                    {
                        sb7369.Append("  ");
                    }
                    i++;
                }
                sb7369.Append("|\n");
                j++;
            }
            sb7369.Append(" ");
            for (i = 0; i < (s1.Length + 2); i++)
            {
                sb7369.Append("-");
            }
            sb7369.Append(" ");
            return sb7369.ToString();
        }
        public static bool Task4515(String a)
        {
            String[] a1 = a.Split(' ');
            int i, j = 0, amount = 0;
            while (j < a1.Length)
            {
                i = j + 1;
                while (i < a1.Length)
                {
                    if (a1[j] == a1[i])
                    {
                        amount++;
                    }
                    i++;
                }
                j++;
            }
            return amount > 0;
        }

        //public static int Task9182(String a)
        //{
        //    String[] a1 = a.Split(' ');
        //    int[] a2 = new int[a1.Length];
        //    for (int i = 0; i < a1.Length; i++)
        //    {
        //        a2[i] = int.Parse(a1[i]);
        //    }
        //    int am1 = 0, am2 = 0;
        //    for (int i = 0; i < a2.Length; i++)
        //    {
        //        int s = a2[i];
        //        for (int j = 0; j < a2.Length - 1; j++)
        //        {
        //            if (s == a2[j + 1])
        //            {
        //                am1++;
        //            }
        //        }
        //        if (am1 > 0)
        //        {
        //            am2++;
        //        }
        //    }
        //    return am2;
        //}
        public static double Task3946(String a)
        {
            if (String.IsNullOrEmpty(a))
            {
                return 0;
            }
            else
            {
                String[] a1 = a.Split(' ');
                int sum = 0;
                for (int i = 0; i < a1.Length; i++)
                {
                    sum += int.Parse(a1[i]);
                }
                return sum / a1.Length;
            }
        }
        public static int Task4283(int k, String a)
        {
            String[] a1 = a.Split(' ');
            int[] a2 = new int[a1.Length];
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = int.Parse(a1[i]);
            }
            int j = 0;
            for (int i = 0; i < a2.Length; i++)
            {
                if (a2[i] == k)
                {
                    j++;
                }
            }
            return j;
        }

    }
}
