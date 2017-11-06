using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab05
    {
        public static bool Task8878(int a, int b)
        {
            return a < b;
        }        

        public static String Task5662(int a, int b, int c)
        {
            return String.Format("уравнение {0}x^2 + {1}b + {2}", a, b, c);
        }
        
        public static bool Task8715(int a, int b, int c)
        {
            return a < b && b < c;
        }
        
        public static bool Task1999(int x, int y)
        {
            return y>=1&&x<=-2;
        }

        public static bool Task4042(double x, double y)
        {
            return y>=-2&&y<=1.5;
        }
        public static bool Task4847(int x, int y, int z)
        {
            return x==y || x==z || y==z;
        }
        public static bool Task6351(double x, double y)
        {
            return y <= 4 && x >= 1 && x <= 2;
        }
    }
}