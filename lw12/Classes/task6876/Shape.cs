using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.task6876
{
    public class Shape
    {
        public static String Header
        {
            get
            {
                return "<svg width=\"150\" height=\"150\">";
            }
        }
        public static String Footer
        {
            get
            {
                return "</ svg >";
            }
        }        
        public virtual double Area { set; get; }
    }
}
