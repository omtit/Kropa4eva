using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] y= new int[100];
            int[] x = new int[100];
            Random rnd = new Random();
            double r;
            String rel = "file.csv";
            using (StreamWriter sw = new StreamWriter(rel))
            {
                sw.WriteLine("x;y;r");
                for (int i = 0; i < y.Length; i++)
                {
                    x[i] = rnd.Next();
                    y[i] = rnd.Next();
                    r = -5 * Math.Sqrt(x[i] + Math.Sqrt(y[i]));
                    sw.WriteLine("{0};{1};{2}", x[i], y[i], r);    
                }
            }
            System.Diagnostics.Process.Start(rel);
        }
    }
}
