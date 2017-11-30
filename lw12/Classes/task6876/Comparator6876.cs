using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6876
{
    public class Comparator6876 : Comparer<Shape>
    {
        public Shape N { set; get; }
        
        public override int Compare(Shape x, Shape y)
        {
            if (x == null || y == null)
            {
                throw new ArgumentException("Конечная точка не инициализирована");
            }
            double a = x.Area;
            double b = y.Area;

            if (a < b)
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
    }
}

