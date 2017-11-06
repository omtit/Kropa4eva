using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab02
    {
        public static double Task4411(double x)
        {
            return x + 7;
        }
        
        public static double Task8428(double a)
        {
            return a*Math.PI/180;
        }
        public static double Task1262(double a)
        {
            return 5*Math.Cos(Task8428(a));
        }
        public static double Task2790(double a)
        {
            return  Math.Sqrt(1-Math.Pow(Math.Sin(Task8428(a)),2));
        }

        public static int Task5063(int a)
        {
            return a%360;
        }
        public static double Task9164(int a,int b)
        {
            return Math.Sin(Task8428(a)) *Math.Cos(Task8428(b)) +Math.Cos(Task8428(a)) *Math.Sin(Task8428(b));
        }

        public static double Task9020(int x)
        {
            if (x > 61)
            {
                throw new Exception("Подкоренное выражение должно быть неотрицательным");
            }
            return 3 * Math.Sqrt(61 - x);
        }
    }
}
