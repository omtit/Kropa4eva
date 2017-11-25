using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 1, 2, 3, 4, 1, 2 };
           
            List<int> L = a.ToList();
            HashSet<int> hashset = new HashSet<int>();
            foreach (var item in a)
            {
                hashset.Add(item);
            }

            Console.WriteLine(String.Join(";", L));
            Console.WriteLine(String.Join(";",hashset));

            int[] b = new int[] { 1, 1, 3, 3, 2, 2 };
            List<int> L1 = b.ToList();
            HashSet<int> hashset1 = new HashSet<int>();
            foreach (var item in b)
            {
                hashset1.Add(item);
            }

            Console.WriteLine(String.Join(";", L1));
            Console.WriteLine(String.Join(";", hashset1));

        }
    }
}
