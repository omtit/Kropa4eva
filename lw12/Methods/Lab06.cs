using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab06
    {
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
            for (int i =17; i < 48; i++)
            {
                sb.Append(i+" ");
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

