using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5108
{
    class Rectangle
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int W { set; get; }
        public int H { set; get; }
        public String Id { set; get; }
        public int Changes { set; get; }

        public Rectangle(int x, int y, int w, int h, String id)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
            Id = id;
        }
        public void ShiftX(int x)
        {
            if (X + x < 0)
            {
                throw new ArgumentException("<p>Значение х должно быть неотрицательным<p/>");
            }
            X += x;
        }
        public void ShiftY(int y)
        {
            if (Y + y < 0)
            {
                throw new ArgumentException("<p>Значение y должно быть неотрицательным<p/>");
            }
            Y += y;
        }
        public void StretchX(int w)
        {
            if (W + w <= 0)
            {
                throw new ArgumentException("<p>Значение W должно быть неотрицательным<p/>");
            }
            W += w;
        }
        public void StretchY(int h)
        {
            if (H + h <= 0)
            {
                throw new ArgumentException("<p>Значение H должно быть неотрицательным<p/>");
            }
            H += h;
        }
        public String Print()
        {
            return "<rect x =\"" + X +
                    "\" y=\"" + Y +
                    "\" width=\"" + W +
                    "\" height=\"" + H + "\" stroke=\"black\" stroke-width=\"1\" fill=\"none\"/>\n";
        }
    }
}
