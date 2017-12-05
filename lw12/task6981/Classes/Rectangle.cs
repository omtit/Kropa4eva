using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6981
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
        public override void ShiftX(int x, ref int i)
        {
            if (X + x < 0 || X + x + W >= 500)
            {
                i++;
            }
            else
            {
                X += x;
                Changes++;
            }
        }
        public override void ShiftY(int y, ref int i)
        {
            if (Y + y < 0 || Y + y + H >= 350)
            {
                i++;               
            }
            else
            {
                Y += y;
                Changes++;
            }
        }
        public override void StretchX(int w, ref int i)
        {
            if (W + w <= 0 || W + w + X >= 500)
            {
                i++;
            }
            else
            {
                W += w;
                Changes++;
            }
        }
        public override void StretchY(int h, ref int i)
        {
            if (H + h <= 0 || Y + h + H >= 350)
            {
                i++;                
            }
            else
            {
                H += h;
                Changes++;
            }
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
            return "\tКоординаты левого верхнего угла ( " + X + " ; " + Y + " ), ширина = " + W + ", высота = " + H;
        }
    }
}

