using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            if (a.Length != 13)
            {
                Console.WriteLine("Некорректная длина штрих-кода");
            }
            else
            {
                string a1 = a.Substring(0, 2);
                string a2 = a.Substring(2, 3);
                string a3 = a.Substring(7, 4);
                string a4 = a.Substring(12, 1);
                Console.WriteLine("Код страны: {0}\nКод изготовителя: {1}\nКод товара: {2}\nКонтрольное число: {3}\n",a1,a2,a3,a4);
            }
        }
    }
}
