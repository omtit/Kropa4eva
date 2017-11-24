using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task1953
{
    public class Interval
    {
        private double a;
        private double b;

        public Interval(double a, double b)
        {
            if (a > b)
            {
                throw new ArgumentException("Некорректный интервал");
            }
            this.a = a;
            this.b = b;
        }

        public double Length
        {
            get
            {
                return b - a;
            }
        }
        public String Print()
        {
            return "[" + a + ";" + b + "]";
        }
    }
}
