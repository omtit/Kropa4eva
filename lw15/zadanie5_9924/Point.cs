﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie5_9924
{
    public class Point
    {
        //private int x;
        //private int y;
        //private String color;

        public int X { set; get; }
        public int Y { set; get; }
        public String Color { set; get; }

        public override String ToString()
        {
            return "{ \"x\":" + X +
                ", \"y\":" + Y + 
                ", \"color\":" + Color + "\" };";
        }
        public override bool Equals(Object o)
        {
            if (o == null || GetType() != o.GetType())
                return false;

            Point p = (Point)o;
            return (X == p.X) && (Y == p.Y);
        }

        public override int GetHashCode()
        {
            return X * Y / 13;
        }
    }
}
