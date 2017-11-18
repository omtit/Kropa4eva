using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6037
{
    public class Interval
    {
        public double a;
        public double b;
        public static bool HasIntersection(Interval x, Interval y)
        {
            if (y == null || x == null)
            {
                throw new ArgumentException("Данный интервал не инициализирован");
            }
            if (x.a > x.b || y.a > y.b)
            {
                throw new InvalidOperationException("Корректность интервала была нарушена");
            }
            return ((y.a >= x.a && y.a <= x.b) || (y.b >= x.a && y.b <= x.b) || (y.a >= x.a && y.a <= x.b && y.b >= x.a && y.b <= x.b));
        }
    }
}
