using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[1000];
            int[] b = new int[1000];
            int[] c = new int[1000];
            int[] d = new int[1000];
            Random rnd = new Random();
            int i = 0, j = 0, k = 0;
            String rel = "file.csv";
            using (StreamWriter sw = new StreamWriter(rel))
            {
                sw.WriteLine("a; b; c; d");
                while (k < 50 || j < 50)
                {
                    a[i] = rnd.Next(1, 50);
                    b[i] = rnd.Next(1, 50);
                    c[i] = rnd.Next(1, 50);
                    d[i] = rnd.Next(1, 50);
                    if ((a[i] <= c[i] && b[i] <= d[i]) || (a[i] <= d[i] && b[i] <= c[i]))
                    {
                        if (k < 50)
                        {
                            sw.WriteLine("{0};{1};{2};{3} Размещение возможно", a[i], b[i], c[i], d[i]);
                            k++;
                        }
                    }
                    else
                    {
                        if (j < 50)
                        {
                            sw.WriteLine("{0};{1};{2};{3} Размешение невозможно", a[i], b[i], c[i], d[i]);
                            j++;
                        }
                    }
                    i++;
                }
                for (i = 0; i < 20; i++)
                {
                    a[i] = rnd.Next(-50, 0);
                    b[i] = rnd.Next(1, 50);
                    c[i] = rnd.Next(1, 50);
                    d[i] = rnd.Next(1, 50);
                    sw.WriteLine("{0};{1};{2};{3} Значение A должно быть больше нуля", a[i], b[i], c[i], d[i]);
                }
                for (i = 0; i < 20; i++)
                {
                    b[i] = rnd.Next(-50, 0);
                    a[i] = rnd.Next(1, 50);
                    c[i] = rnd.Next(1, 50);
                    d[i] = rnd.Next(1, 50);
                    sw.WriteLine("{0};{1};{2};{3} Значение B должно быть больше нуля", a[i], b[i], c[i], d[i]);
                }
                for (i = 0; i < 20; i++)
                {
                    c[i] = rnd.Next(-50, 0);
                    b[i] = rnd.Next(1, 50);
                    a[i] = rnd.Next(1, 50);
                    d[i] = rnd.Next(1, 50);
                    sw.WriteLine("{0};{1};{2};{3} Значение C должно быть больше нуля", a[i], b[i], c[i], d[i]);
                }
                for (i = 0; i < 20; i++)
                {
                    d[i] = rnd.Next(-50, 0);
                    b[i] = rnd.Next(1, 50);
                    c[i] = rnd.Next(1, 50);
                    a[i] = rnd.Next(1, 50);
                    sw.WriteLine("{0};{1};{2};{3} Значение D должно быть больше нуля", a[i], b[i], c[i], d[i]);
                }
            }

            System.Diagnostics.Process.Start(rel);
        }
    }
}
