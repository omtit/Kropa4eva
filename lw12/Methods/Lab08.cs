using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{

    public class Lab08
    {
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
