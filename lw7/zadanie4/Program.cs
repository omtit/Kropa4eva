using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "abcdacadbacdaabaadc";
            string a = Console.ReadLine();
            if (a.Length !=2)
            {
                Console.WriteLine("Вводимая строка должна содержать ровно 2 символа");
                return;
            }
            int i = 0;
            int j = s.IndexOf(a);
            if ( j == -1)
            {
                Console.WriteLine("Строка s не содержит комбинацию");
            }
            else
            {
                 while (i < s.Length)
                {
                    if (s[i] == a[0] && s[i+1] == a[1])
                    {                        
                        Console.Write(i +" ");
                    }
                    i++;                    
                }  

                    
                
            }

        }
    }
}
