using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadahnie9
{
    class Program
    {
        static void Main(string[] args)
        {
            String ID;
            ID = Console.ReadLine();
            Console.WriteLine("SELECT first_name, last_name, group FROM students WHERE id = '" + ID +"';");

        }
    }
}
