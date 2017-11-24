using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3567
{
    public class Circle
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int R { set; get; }

        public Circle(int x, int y, int r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;
        }
        public int ShiftX(int x)
        {
            return X + x;
        }
        public int ShiftY(int y)
        {
            return Y + y;
        }

        public void StretchX(int x)
        {
            Y += x / 2;
            X += x / 2;
            R += x / 2;
        }
        public void StretchY(int x)
        {
            X += x / 2;
            Y += x / 2;
            R += x / 2;
        }
        public String Print1()
        {
            return "<circle cx =\"" + X +
                    "\" cy=\"" + Y +
                    "\" r=\"" + R + " \"stroke=\"red\" stroke-width=\"1\" fill=\"none\"/>\n";
        }
        public String Print2()
        {
            return "<circle cx =\"" + X +
                    "\" cy=\"" + Y +
                    "\" r=\"" + R + " \"stroke=\"black\" stroke-width=\"1\" fill=\"none\"/>\n";
        }
    }
}
