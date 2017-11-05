using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie3
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String rel1 = "7343\\" + a + ".txt";
            int[] s = new int[5];
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
                    s[i] = int.Parse(str.ReadLine());
                    i++;
                }
            }
            int x = s[0], y = s[1], width = s[2], height = s[3], r = s[4], x1 = x + width, y1 = y + height;
            if (width <= 0)
            {
                Console.WriteLine("Ширина прямоугольника должна быть положительной");
                return;
            }
            if (height <= 0)
            {
                Console.WriteLine("Высота прямоугольника должна быть положительной");
                return;
            }
            if (r <= 0)
            {
                Console.WriteLine("Радиус должен быть положительным");
                return;
            }
            if (x + width > 800 || y + height > 600 || x < 0 || y < 0)
            {
                Console.WriteLine("Все точки прямоугольника должны находиться в пределах рисунка");
                return;
            }
            if (x-r<0 || x1+r>800 || y - r <0 || y1 + r > 600)
            {
                Console.WriteLine("Все точки окружностей должны находиться в пределах рисунка");
                return;
            }
            String a1 = Console.ReadLine();
            String rel = "pic" + a1 + ".html";
            using (StreamWriter sw = new StreamWriter(rel))
            {
                sw.WriteLine("<!DOCTYPE html>\n<html>\n<head>\n    <meta charset=\"utf-8\"/>\n<head/>\n<body>\n\n<svg width=\"800\" height=\"600\">");                
                sw.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\"  fill=\"yellow\"/>",x,y,r);
                sw.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\"  fill=\"yellow\"/>",x,y1,r);
                sw.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\"  fill=\"yellow\"/>",x1,y,r);
                sw.WriteLine("<circle cx=\"{0}\" cy=\"{1}\" r=\"{2}\"  fill=\"yellow\"/>",x1,y1,r);
                sw.WriteLine("<rect x=\"{0}\" y=\"{1}\" width=\"{2}\" height=\"{3}\" fill=\"red\" opacity =\"0.5\"/>", x, y, width, height);
                sw.WriteLine("</ svg >\n </ body >\n </ html > ");
            }
            System.Diagnostics.Process.Start(rel);
        }
    }
}
