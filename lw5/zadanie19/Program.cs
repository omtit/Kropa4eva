﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie19
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()), y = double.Parse(Console.ReadLine());
            if (x < -2 || x == -2)
            {
                if (y > 1 || y == 1 )
                {
                    Console.WriteLine("Точка принадлежит области");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Точка не принадлежит области");
            }
        }
    }
}
