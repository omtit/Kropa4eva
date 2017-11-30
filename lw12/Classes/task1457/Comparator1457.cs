using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task1457
{
    public class Comparator1457 : Comparer<Point>

    {
        public Point Target { set; get; }

        public Comparator1457(Point x)
        {
            Target = x ?? throw new ArgumentException("Целевая точка не инициализирована");
        }
        public override int Compare(Point x, Point y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Конечная точка не инициализирована");
            }
            double a = x.DistanceTo(Target);
            double b = y.DistanceTo(Target);

            if (a > b)
            {
                return 1;
            }
            else if (a == b)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
        public int Count(List<Point> x)
        {
            return x.Count();
        }
    }
}
