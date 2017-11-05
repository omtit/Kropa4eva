using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            Random rnd = new Random();
            double c;
            String rel = "file.csv";
            using (StreamWriter sw = new StreamWriter(rel))
            {
                sw.WriteLine("R;C");
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = rnd.Next();
                    c = 2 * Math.PI * a[i];
                    sw.WriteLine("{0};{1:F4}", a[i], c);
                }
            }
            System.Diagnostics.Process.Start(rel);
        }
    }
}
