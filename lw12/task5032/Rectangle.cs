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
        public void ShiftX(int x)
        {
            if (X + x < 0)
            {
                throw new ArgumentException("<p>\nОшибка: Координата X должна быть неотрицательной\nПоследнее корректное состояние:<p/>");
            }
            X += x;
        }
        public void ShiftY(int y)
        {
            if (Y + y < 0)
            {
                throw new ArgumentException("<p>\nОшибка: Координата Y должна быть неотрицательной\nПоследнее корректное состояние:<p/>");
            }
            Y += y;
        }
        public void StretchX(int w)
        {
            if (W + w <= 0)
            {
                throw new ArgumentException("<p>\nОшибка: Ширина должна быть положительной\nПоследнее корректное состояние:<p/>");
            }
            W += w;
        }
        public void StretchY(int h)
        {
            if (H + h <= 0)
            {
                throw new ArgumentException("<p>\nОшибка: Высота должна быть положительной\nПоследнее корректное состояние:<p/>");
            }
            H += h;
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
