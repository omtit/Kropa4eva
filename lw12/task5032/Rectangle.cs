using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5032
{
    public class Rectangle
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int W { set; get; }
        public int H { set; get; }

        public Rectangle(int x, int y, int w, int h)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
        }
        public int ShiftX(int x)
        {
            return X + x;
        }
        public int ShiftY(int y)
        {
            return Y + y;
        }
        public int StretchX(int w)
        {
            return W + w;
        }
        public int StretchY(int h)
        {
            return H + h;
        }
        public String Print1()
        {
            return "<rect x =\"" + X +
                    "\" y=\"" + Y +
                    "\" width=\"" + W +
                    "\" height=\"" + H + "\" stroke=\"red\" stroke-width=\"1\" fill=\"none\"/>\n";
        }
        public String Print2()
        {
            return "<rect x =\"" + X +
                    "\" y=\"" + Y +
                    "\" width=\"" + W +
                    "\" height=\"" + H + "\" stroke=\"black\" stroke-width=\"1\" fill=\"none\"/>\n";
        }
    }
}
