using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task2000
{
    public class Interval
    {
        public int x;
        public int y;
        public Interval(int x, int y)
        {            
            if (x >= y)
            {
                throw new ArgumentException("Некорректный интервал");
            }            
                this.x = x;
                this.y = y;
           
        }
        public String Print()
        {
            return "[" + x + ";" + y + "]";
        }
        public void Slide(int a)
        {
            x = x + a;
            y = y + a;
        }
        public void Squeeze(int a)
        {                        
            if (y-x < a)
            {
                throw new ArgumentException("Невозможно уменьшить интервал на указанную длину");
            }
            y = y - a;
        }
        public double Length
        {
            get
            {
                return y - x;
            }
        }

    }
}
