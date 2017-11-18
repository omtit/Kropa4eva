using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task9713
{
    public class Interval
    {
        public int a;
        public int b;
        public override string ToString()
        {
            if (a > b)
            {
                return "[ Некорректный интервал " + a + ";" + b + "]";
            }           
            else
            {
                return "[" + a + ";" + b + "]";
            }
        }
        public bool Intersects(Interval x)
        {
            //if (x == null)
            //{
            //    throw new ArgumentException("Данный интервал не инициализирован");
            //}
            //if (a > b)
            //{
            //    throw new InvalidOperationException("Корректность интервала была нарушена");
            //}
            //if (x.a > x.b)
            //{
            //    throw new ArgumentException("Некорректный интервал");
            //}
            return ((a >= x.a && a <= x.b) || (b >= x.a && b <= x.b) || (a >= x.a && a <= x.b && b >= x.a && b <= x.b));
        }

    }
}
