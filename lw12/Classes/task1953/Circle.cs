using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task1953
{
    public class Circle
    {
        private double x;
        private double y;
        private double r;

        public Circle(double x, double y, double r)
        {
            this.x = x;
            this.y = y;
            this.r = r;
        }
        public override String ToString()
        {
            return "<circle cx = \"" + x + "\" cy = \"" + y + "\" r = \"" + r + "\" />";
        }
        public double Area
        {
            get
            {
                return Math.PI * Math.Pow(r, 2);
            }
        }
        public Interval MakeProjectionX()
        {
            return new Interval(x - r, x + r);
        }

        public Interval MakeProjectionY()
        {
            return new Interval(y - r, y + r);
        }
    }
}
