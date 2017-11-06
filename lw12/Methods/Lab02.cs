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
        
        public static double Task8428(int a)
        {
            return 0.0;
        }
        
        public static int Task5063(int a)
        {
            return 0;
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
