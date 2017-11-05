using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie5
{
    class Program
    {
        static void Main(string[] args)
        {
            String b = Console.ReadLine();
            String rel1 = "6409\\" + b + ".txt";
            double[] s = new double[4];
            int i = 0;
            using (StreamReader str = new StreamReader(rel1))
            {
                if (!File.Exists(rel1))
                {
                    Console.WriteLine("Файл {0} не найден", Path.GetFullPath(rel1));
                    return;
                }
                while (!str.EndOfStream)
                {
                    s[i] = double.Parse(str.ReadLine());
                    i++;
                }
            }
            double x = s[0], y = s[1], a = s[2], l = s[3], x1 = x + a, x2 = x1 - a / 2;
            if (a <= 0)
            {
                Console.WriteLine("Длина основания должна быть положительна");
                return;
            }
            if (l <= 0)
            {
                Console.WriteLine("Длина боковой стороны должна быть положительна");
                return;
            }
            double c = Math.Pow(l,2) - (Math.Pow(a,2) / 4);
            if (c <= 0)
            {
                Console.WriteLine("Невозможно сформировать треугольник с данными длинами сторон");
                return;
            }
            double h = (Math.Sqrt(c)), y1 = y + h;
            if (x1 > 800 || y1 > 600)
            {
                Console.WriteLine("Фигура не помещается внутри рисунка");
                return;
            }           
            String a1 = Console.ReadLine();
            String rel = "pic" + a1 + ".html";
           
            using (StreamWriter sw = new StreamWriter(rel))
            {
                sw.WriteLine("<!DOCTYPE html>\n<html>\n<head>\n    <meta charset=\"utf-8\"/>\n<head/>\n<body>\n<svg width=\"800\" height=\"600\">");
                sw.WriteLine("<line x1=\"{0}\" y1=\"{1}\" x2=\"{2}\" y2 =\"{3}\" stroke=\"blue\"\nstroke-width=\"1\" />", x, y, x1, y);
                sw.WriteLine("<line x1=\"{0}\" y1=\"{1}\" x2=\"{2:F0}\" y2 =\"{3:F0}\" stroke=\"blue\"\nstroke-width=\"1\" />", x, y, x2, y1);
                sw.WriteLine("<line x1=\"{0}\" y1=\"{1}\" x2=\"{2:F0}\" y2 =\"{3:F0}\" stroke=\"blue\"\nstroke-width=\"1\" />", x1, y, x2, y1);
                sw.WriteLine("</svg>\n</body>\n</html>");
            }
            System.Diagnostics.Process.Start(rel);
        }
    }
}
