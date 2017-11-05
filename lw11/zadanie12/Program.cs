using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[200];
            int[] b1 = new int[200];
            int[] a2 = new int[200];
            int[] b2 = new int[200];
            Random rnd = new Random();
            int i = 0, j = 0, k = 0, l = 0, a, b;
            String rel = "file.csv";
            using (StreamWriter sw = new StreamWriter(rel)) { 
                sw.WriteLine("A1;B1;A2;B2;Результат");
                while (l < 30 || j < 30 || k < 20)
                {
                    a1[i] = rnd.Next(-50, 50);
                    b1[i] = rnd.Next(-50, 50);
                    a2[i] = rnd.Next(-50, 50);
                    b2[i] = rnd.Next(-50, 50);
                    if (a1[i] > b1[i] || a2[i] > b2[i])
                    {
                        if (k < 20)
                        {
                            sw.WriteLine("{0};{1};{2};{3}; Значение A должно быть меньше значения B", a1[i], b1[i], a2[i], b2[i]);
                            k++;
                            i++;
                            continue;
                        }
                    }
                    if ((a1[i] < a2[i] && b1[i] < a2[i]) || (a1[i] > b2[i] && b1[i] > b2[i]))
                    {
                        if (j < 30)
                        {
                            sw.WriteLine("{0};{1};{2};{3}; Интервалы не пересекаются", a1[i], b1[i], a2[i], b2[i]);
                            j++;
                            i++;
                        }
                    }
                    else
                    {
                        if (a1[i] < a2[i])
                        {
                            a = a2[i];
                        }
                        else
                        {
                            a = a1[i];
                        }
                        if (b1[i] < b2[i])
                        {

                            b = b1[i];
                        }
                        else
                        {
                            b = b2[i];
                        }
                        if (l < 30)
                        {
                            sw.WriteLine("{0};{1};{2};{3}; Интервалы пересекаются ({4}\\;{5})", a1[i], b1[i], a2[i], b2[i], a, b);
                            l++;
                            i++;
                        }
                    }
                }
                System.Diagnostics.Process.Start(rel);
            }
        }
    }
}
