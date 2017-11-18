using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Methods;
using System.IO;

namespace task6882
{
    class Lab13Task6882
    {
        static void Main(string[] args)
        {
            //try
            //{

            //    StreamReader abs = new StreamReader("sdf");
            //    int x = int.Parse("fifg");
            //}
            //catch(Exception d)
            //{
            //    Console.WriteLine("Не удается считать число");
            //}          
            for (int a = 1; a <= 8; a++)
            {
                try
                {
                    String rel = "task6882\\test" + a + ".txt";
                    using (StreamReader str = new StreamReader(rel))
                    {
                        if (!str.EndOfStream)
                        {
                            int b = 0, x = int.Parse(str.ReadLine());
                            while (!str.EndOfStream)
                            {
                                b = int.Parse(str.ReadLine());
                                if (b < x)
                                {
                                    x = b;
                                }
                            }
                            Console.WriteLine(x);
                        }
                        else
                        {
                            Console.WriteLine("Файл пуст");
                        }
                    }
                }
                catch (FileNotFoundException e)
                {
                    Console.WriteLine("Файл не существует");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Не удается считать число");
                }
            }
        }
    }
}
