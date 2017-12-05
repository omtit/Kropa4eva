using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2033
{
    public abstract class Shape
    {
        public int X { set; get; }
        public int Y { set; get; }
        public String Id { set; get; }
        public int Changes { set; get; }

        public Shape(int x, int y, String id)
        {
            X = x;
            Y = y;
            Id = id;
        }
        public abstract void ShiftX(int x);
        public abstract void ShiftY(int x);
        public abstract void StretchX(int x);
        public abstract void StretchY(int x);
        public abstract String Print();
        public abstract String ShowC();
    }
}
