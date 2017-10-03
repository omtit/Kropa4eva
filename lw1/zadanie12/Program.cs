using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie12
{
    class Program
    {
        static void Main(string[] args)
        {
            String USER, PASS, HOST, PORT, DB;
            USER = Console.ReadLine();
            PASS = Console.ReadLine();
            HOST = Console.ReadLine();
            PORT = Console.ReadLine();
            DB = Console.ReadLine();
            Console.WriteLine("User ID="+USER+";Password="+PASS+";Host="+HOST+";Port="+PORT+";Database="+DB+";");

        }
    }
}
