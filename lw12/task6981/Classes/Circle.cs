using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task6981
{
    class Circle : Shape
    {
        public int R { set; get; }

        public Circle(int x, int y, int r, String id) : base(x, y, id)
        {
            R = r;
        }
        public override void ShiftX(int x, ref int i)
        {
            if (X + x < 0 || X + x > 500 || X + x - R < 0 || X + x - R > 500)
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
            if (Y + y < 0 || Y + y > 350 || Y + y - R < 0 || y + Y + R > 350)
            {
                i++;
            }
            else
            {
                Y += y;
                Changes++;
            }
        }
        public override void StretchY(int x, ref int i)
        {
            if (R + x / 2 <= 0 || X + x / 2 > 500 || X + x / 2 < 0 || Y + x / 2 < 0 || Y + x / 2 > 350)
            {
                i++;              
            }
            else
            {
                X += x / 2;
                Y += x / 2;
                R += x / 2;
                Changes++;
            }
        }
        public override void StretchX(int x, ref int i)
        {
            if (R + x / 2 <= 0 || X + x / 2 > 500 || X + x / 2 < 0 || Y + x / 2 < 0 || Y + x / 2 > 350)
            {
                i++;
            }
            else
            {
                X += x / 2;
                Y += x / 2;
                R += x / 2;
                Changes++;
            }
        }

        public override String Print()
        {
            return "<circle cx =\"" + X +
                    "\" cy=\"" + Y +
                    "\" r=\"" + R + " \"stroke=\"black\" stroke-width=\"1\" fill=\"none\"/>\n";
        }
        public override String ShowC()
        {
            return "\tКоординаты центра ( " + X + " ; " + Y + " ),  радиус = " + R;
        }
    }
}
