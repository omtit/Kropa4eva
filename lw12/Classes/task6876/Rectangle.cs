using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6876
{
    public class Rectangle : Shape
    {
        public int X { set; get; }
        public int Y { set; get; }
        public int W { set; get; }
        public int H { set; get; }

        public override double Area
        {
            get
            {
                return W * H;
            }
        }

        public Rectangle(int x, int y, int w, int h)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
        }
        public override string ToString()
        {
            return "< rect x = '"+X+"' y = '"+Y+"' width = '"+W+"' height = '"+H+"' stroke = 'black' stroke - width = '1' fill = 'transparent' />";
        }

    }
}
