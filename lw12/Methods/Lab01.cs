using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Methods
{
    public class Lab01
    {
        public static void Task1860(String a)
        {
            Console.WriteLine("Мы стремимся к " + a);
        }

        public static void Task4764(String a)
        {
            Console.WriteLine(a + " нас не остановят!");
        }

        public static void Task2429(String a)
        {
            Console.WriteLine("Программирование " + a + "!");
        }

        public static void Task7472(String a, String b)
        {
            Console.WriteLine(b + " " + a);
        }

        public static void Task3862()
        {
            Console.WriteLine("{0:F4}", Math.PI);
            Console.WriteLine("{0:F4}", Math.E);
        }

        public static void Task9231(double a)
        {
            Console.WriteLine("{0:F4}", a);
        }

        public static void Task8624(int a)
        {
            Console.WriteLine("\"{0}\"", a);
        }

        public static void Task2959(String id)
        {
            Console.WriteLine("SELECT first_name, last_name, group\nFROM students WHERE id = '{0}';", id);
        }
        public static void Task7271(int a,int b)
        {
            Console.WriteLine("INSERT INTO POINTS (x, y)\nVALUES ('{0}', '{1}');",a,b);
        }
        public static void Task2632(int cx, int cy, int r,String fill)
        {
            Console.WriteLine("<circle cx=\"{0}\" cy=\"{1}\"\nr=\"{2}\" fill=\"{3}\"/>",cx,cy,r,fill);
        }
        public static void Task4343(String user, String pas, String host, String port, String db)
        {
            Console.WriteLine("User ID={0};Password={1};\nHost={2};Port={3};Database={4};",user,pas,host,port,db);
        }
    }
}