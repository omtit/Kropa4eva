using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task7297
{
    public class Interval
    {
        public int a;
        public int b;
        public bool Contains(int x)
        {
            if (a > b)
            {
                throw new InvalidOperationException("Корректность интервала была нарушена");
            }
            return x > a && x < b;
        }

    }
}
