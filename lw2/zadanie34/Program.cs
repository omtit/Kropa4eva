﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie34
{
    class Program
    {
        static void Main(string[] args)
        {
            double res, aInGrad = double.Parse(Console.ReadLine()), bInGrad = double.Parse(Console.ReadLine());
            res = 3 * Math.Sin(2 * Math.PI * aInGrad / 180) * Math.Cos(3 * Math.PI * bInGrad / 180);
            Console.WriteLine("{0:F4}",res);
        }
    }
}
