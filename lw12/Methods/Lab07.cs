using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab07
    {
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
            if (a.Substring(0,1) == a1)
            {
                a = a.ToUpper();                
            }           
            if (a.Substring(0,1) == a2)
            {
                a = a.ToLower();                
            }
            return a;
        }
    }
}
