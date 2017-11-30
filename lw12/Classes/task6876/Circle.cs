using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6876
{
    public class Circle : Shape
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int R { set; get; }

        public override double Area
        {
            get { return Math.PI * R * R; }
        }

        public Circle(int x, int y, int r)
        {
            X = x;
            Y = y;
            R = r;
        }
        public override String ToString()
        {
            return "< circle cx = '" + X + "' cy = '" + Y + "' r = '" + R + "' stroke = 'black' stroke - width = '1' fill = 'transparent' />";
        }

    }
}
