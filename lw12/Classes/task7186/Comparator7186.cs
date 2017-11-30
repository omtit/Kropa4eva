using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task7186
{
    public class Comparator7186 : Comparer<int>
    {
        public int X { set; get; }

        public Comparator7186(int x)
        {
            X = x;
        }
        public override int Compare(int x, int y)
        {
            int d1 = Math.Abs(x - X);
            int d2 = Math.Abs(y - X);
            if (d1 > d2)
            {
                return 1;
            }
            else if (d1 == d2)
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
