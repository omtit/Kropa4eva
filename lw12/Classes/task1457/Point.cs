using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task1457
{
    public class Point
    {
        public int X { set; get; }
        public int Y { set; get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public double DistanceTo(Point p)
        {
            int dx = p.X - X;
            int dy = p.Y - Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }
        public override String ToString()
        {            
            return "(" + X + ";" + Y + ")";
        }

    }
}
