using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie2
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String rel1 = "3951\\" + a + ".txt";
            int[] s = new int[4];
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
            if (s[2] <= 0)
            {
                Console.WriteLine("Ширина прямоугольника должна быть положительной");
                return;
            }
            if (s[3] <= 0)
            {
                Console.WriteLine("Высота прямоугольника должна быть положительной");
                return;
            }
            if (s[0] < 0 || s[0] > 800 || s[0] + s[2] > 800 || s[2] > 800 || s[1] < 0 || s[1] + s[3] > 600 || s[3] > 600)
            {
                Console.WriteLine("Все точки прямоугольника должны находиться в пределах рисунка");
                return;
            }
            String a1 = Console.ReadLine();
            String rel = "pic" + a1 + ".html";
            using (StreamWriter sw = new StreamWriter(rel))
            {
                sw.WriteLine("<!DOCTYPE html>\n<html>\n<head>\n    <meta charset=\"utf-8\"/>\n<head/>\n<body>\n\n<svg width=\"800\" height=\"600\">");
                sw.WriteLine("<rect x=\"{0}\" y=\"{1}\" width=\"{2}\" height=\"{3}\"stroke=\"blue\"\nstroke-width=\"2\" fill=\"red\"/>\n    </svg>\n</body>\n</html> ", s[0], s[1], s[2], s[3]);
            }
            System.Diagnostics.Process.Start(rel);
        }
    }
}
