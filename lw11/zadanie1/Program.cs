using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie1
{
    class Program
    {
        static void Main(string[] args)
        {
            String a = Console.ReadLine();
            String rel = "pic" + a + ".html";
            int cx = int.Parse(Console.ReadLine());
            int cy = int.Parse(Console.ReadLine());
            int r = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());            
            using (StreamWriter sw = new StreamWriter(rel))
            {
                    sw.WriteLine("<!DOCTYPE html>\n<html>\n<head>\n    <meta charset=\"utf-8\"/>\n<head/>\n<body>\n    <h1>Мой первый векторный рисунок</h1>\n\n<svg width=\"800\" height=\"600\">");
                    sw.WriteLine("<circle cx=\""+cx+"\" cy=\""+cy+"\" r=\""+r+"\" stroke=\"green\"\nstroke-width=\""+width+"\" fill=\"yellow\"/>\n    </svg>\n</body>\n</html> ");
            }
            System.Diagnostics.Process.Start(rel);
        }
    }
}
