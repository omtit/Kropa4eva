using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2033
{
    class Rectangle : Shape
    {        
        public int W { set; get; }
        public int H { set; get; }

        public Rectangle(int x, int y, int w, int h, String id) : base(x, y, id)
        {
            W = w;
            H = h;
        }
        public override void ShiftX(int x)
        {
            if (X + x < 0)
            {
                throw new ArgumentException("<p>Значение X должно быть неотрицательным<p/>");
            }
            X += x;
            Changes++;
        }
        public override void ShiftY(int y)
        {
            if (Y + y < 0)
            {
                throw new ArgumentException("<p>Значение Y должно быть неотрицательным<p/>");
            }
            Y += y;
            Changes++;
        }
        public override void StretchX(int w)
        {
            if (W + w <= 0)
            {
                throw new ArgumentException("<p>Значение W должно быть неотрицательным<p/>");
            }
            W += w;
            Changes++;
        }
        public override void StretchY(int h)
        {
            if (H + h <= 0)
            {
                throw new ArgumentException("<p>Значение H должно быть неотрицательным<p/>");
            }
            H += h;
            Changes++;
        }
        public override String Print()
        {
            return "<rect x =\"" + X +
                    "\" y=\"" + Y +
                    "\" width=\"" + W +
                    "\" height=\"" + H + "\" stroke=\"black\" stroke-width=\"1\" fill=\"none\"/>\n";
        }
        public override String ShowC()
        {
            return "\tКоординаты левого верхнего угла ( "+X+" ; "+Y+" ), ширина = "+W+", высота = "+H;
        }
    }
}

