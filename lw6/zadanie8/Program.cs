using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie8
{
    class Program
    {
        static void Main(string[] args)
        {
            int w,i = 1, x = 453;           
            while (i <= 20)
            {
                w = i * x; 
                Console.WriteLine("{0}     {1}",i,w);
                i++;
            }

        }
    }
}
