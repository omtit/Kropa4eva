using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2033
{
    class Circle : Shape
    {
        public int R { set; get; }

        public Circle(int x, int y, int r, String id) : base(x, y, id)
        {
            R = r;
        }
        public override void ShiftX(int x)
        {
            if (X + x < 0)
            {
                throw new ArgumentException("<p>Координата X должна быть неотрицательной.<p/>");
            }
            if (X + x - R < 0)
            {
                throw new ArgumentException("<p>Левая точка окружности должна быть неотрицательной<p/>");
            }
            X += x;
            Changes++;
        }
        public override void ShiftY(int y)
        {
            if (Y + y < 0)
            {
                throw new ArgumentException("<p>Координата Y должна быть неотрицательной.<p/>");
            }
            if (Y + y - R < 0)
            {
                throw new ArgumentException("<p>Верхняя точка окружности должна быть неотрицательной.<p/>");
            }
            Y += y;
            Changes++;
        }
        public override void StretchY(int x)
        {
            if (R + x / 2 <= 0)
            {
                throw new ArgumentException("<p>Высота должна быть положительной.<p/>");
            }
            X += x / 2;
            Y += x / 2;
            R += x / 2;
            Changes++;
        }
        public override void StretchX(int x)
        {
            if (R + x / 2 <= 0)
            {
                throw new ArgumentException("<p>Ширина должна быть положительной.<p/>");
            }
            X += x / 2;
            Y += x / 2;
            R += x / 2;
            Changes++;
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
