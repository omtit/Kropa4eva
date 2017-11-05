using Methods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Step1();
            //Console.WriteLine();
            //Step2();
            //Console.WriteLine();
            //Step3();
            //Console.WriteLine();
            //Step4();
            //Console.WriteLine();
            //Step5();
            //Console.WriteLine();
            //Step6();
            //Console.WriteLine();
            //Step7();
            //Console.WriteLine();
            Step8();
            Console.WriteLine();
            Step9();
            Console.WriteLine();
            Step10();
            Console.WriteLine();
            Step11();
        }

        //static void Step1()
        //{
        //    Lab01.task1860("знаниям");
        //    Lab01.task1860("цели");
        //    Lab01.task1860("результату");
        //}

        //static void Step2()
        //{
        //    Lab01.task4764("трудности");
        //    Lab01.task4764("загадки");
        //    Lab01.task4764("сложные задачи");
        //}

        //static void Step3()
        //{
        //    Lab01.task2429("просто");
        //    Lab01.task2429("интересно");
        //    Lab01.task2429("перспективно");
        //}

        //static void Step4()
        //{
        //    Lab01.task7472("начало", "конец");
        //    Lab01.task7472("сила", "знание");
        //    Lab01.task7472("курица", "яйцо");
        //    Lab01.task7472("шаг", "шаг");
        //}

        //static void Step5()
        //{
        //    Lab01.task2862();
        //}

        //static void Step6()
        //{
        //    Lab01.task9231(9.780327);
        //    Lab01.task9231(-273.15);
        //    Lab01.task9231(0.00006);
        //}

        //static void Step7()
        //{
        //    Lab01.task8624(811);
        //    Lab01.task8624(1583);
        //}

        static void Step8()
        {
            Lab01.task2959("123456789");
            Lab01.task2959("fa93f");
        }

        static void Step9()
        {
            Lab01.task7271(5, 7);
            Lab01.task7271(-1, 1000);
        }

        static void Step10()
        {
            Lab01.task2632(50, 50, 40, "yellow");
            Lab01.task2632(400, 300, 200, "green");
            Lab01.task2632(
                254,
                356,
                100,
                "#cc6600");
        }
        static void Step11()
        {
            Lab01.task4343("test", "pass", "localhost", "5432", "my_db");
            Lab01.task4343("admin", "7e8efd48d69c", "localhost", "5432", "bank");
            Lab01.task4343("akryukov", "123", "localhost", "dev-node1", "bank");

        }
    }
}
