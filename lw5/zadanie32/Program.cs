using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie32
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double h1 = double.Parse(Console.ReadLine());
            if (h1 <= 0)
            {
                Console.WriteLine("Высота должна быть положительна");
            }
            double w1 = double.Parse(Console.ReadLine());
            if (w1 <= 0)
            {
                Console.WriteLine("Ширина должна быть положительна");
            }
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double h2 = double.Parse(Console.ReadLine());
            if (h2 <= 0)
            {
                Console.WriteLine("Высота должна быть положительна");
            }
            double w2 = double.Parse(Console.ReadLine());
            if (w2 <= 0)
            {
                Console.WriteLine("Ширина должна быть положительна");               
            }
            // Вершины первого прямоугольника (x1;y1),(x1;y12),(x12;y12),(x12;y1)
            // Вершины второго прямоугольника (x2;y2),(x2;y22),(x22;y22)(x22;y2)
            double x12, x22, y12, y22, x3, y3, h3, w3;
            x12 = x1 + w1;
            x22 = x2 + w2;
            y12 = y1 + h1;
            y22 = y2 + h2;
            if ((x1 < x2 && x12 < x2) ||  (x1 > x22 && x12 > x22) || (y2 < y12 && y22 < y12) || (y2 > y1 && y22 > y1))
            {
                Console.WriteLine("Не пересекаются");
            }
            else
            {
                if (x2 >= x1 && x2 <= x12 && y2 <= y1 && y2 >= y12)
                {
                    x3 = x2;
                    y3 = y2;
                    w3 = x12 - x2;
                    h3 = y2 - y12;
                    Console.WriteLine("{\"x\":" + x3 + ",\"y\":" + y3 + ",\"w\":" + w3 + ",\"h\":" + h3);
                }
                else
                {
                    if (x1 >= x2 && x1 <= x22 && y2 <= y1 && y2 >= y12)
                    {
                        x3 = x1;
                        y3 = y2;
                        w3 = x22 - x1;
                        h3 = y2 - y12;
                        Console.WriteLine("{\"x\":" + x3 + ",\"y\":" + y3 + ",\"w\":" + w3 + ",\"h\":" + h3);
                    }
                    else
                    {
                        if (x1 >= x2 && x1 <= x22 && y1 >= y22 && y1 <= y2)
                        {
                            x3 = x1;
                            y3 = y1;
                            w3 = x22 - x1;
                            h3 = y1 - y22;
                            Console.WriteLine("{\"x\":" + x3 + ",\"y\":" + y3 + ",\"w\":" + w3 + ",\"h\":" + h3);
                        }
                        else
                        {
                            if (x2 < x1 && x1 > x12 && y1 > y22 && y1 < y2)
                            {
                                x3 = x2;
                                y3 = y1;
                                w3 = x12 - x2;
                                h3 = y1 - y22;
                                Console.WriteLine("{\"x\":" + x3 + ",\"y\":" + y3 + ",\"w\":" + w3 + ",\"h\":" + h3);
                            }
                        }
                    }
                }
               
                
            }
           





        }
    }
}
