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
            X = x;
            Y = y;
            R = r;
        }
        public void ShiftX(int x)
        {
            if (X + x < 0)
            {
                throw new ArgumentException("<p>\nОшибка: Координата X должна быть неотрицательной\nПоследнее корректное состояние:<p/>");
            }
            if (X + x - R < 0)
            {
                throw new ArgumentException("<p>\nОшибка: Левая точка окружности должна быть неотрицательной\nПоследнее корректное состояние:<p/>");
            }
                X += x;
        }
        public void ShiftY(int y)
        {
            if (Y + y < 0)
            {
                throw new ArgumentException("<p>\nОшибка: Координата Y должна быть неотрицательной\nПоследнее корректное состояние:<p/>");
            }
            if (Y + y - R < 0)
            {
                throw new ArgumentException("<p>\nОшибка: Верхняя точка окружности должна быть неотрицательной\nПоследнее корректное состояние:<p/>");
            }
            Y += y;
        }
        public void StretchX(int x)
        {
            if (R + x / 2 < 0)
            {
                throw new ArgumentException("<p>\nОшибка: Ширина должна быть положительной.\nПоследнее корректное состояние:<p/>");
            }
            R += x / 2;
            X += x / 2;
            Y += x / 2;
        }
        public void StretchY(int x)
        {
            if (R + x / 2 < 0)
            {
                throw new ArgumentException("<p>\nОшибка: Высота должна быть положительной.\nПоследнее корректное состояние:<p/>");
            }
            R += x / 2;
            X += x / 2;
            Y += x / 2;
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
