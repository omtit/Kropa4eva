using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task2662
{
    public class Interval
    {
        public int x;
        public int y;
        public Interval(int x, int y)
        {
            if (x >= y)
            {
                throw new ArgumentException("Некорректный интервал");
            }
            this.x = x;
            this.y = y;

        }
        public bool Equals(Interval a, Interval b)
        {
            if (a == null || b == null)
            {
                throw new ArgumentException("Данный интервал не инициализирован");
            }
            if (a.x > a.y || b.x > b.y)
            {
                throw new InvalidOperationException("Корректность интервала была нарушена");
            }
            return a.x == b.x && b.y == a.y;
        } 
    }
}
