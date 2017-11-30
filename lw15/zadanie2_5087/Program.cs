using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2_5087
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = new int[] { 1, 2, 3, 4, 1, 2 };
            int[] a2 = new int[] { 1, 1, 3, 3, 2, 2 };
            List<int> L1 = new List<int>();
            List<int> L2 = new List<int>();
            HashSet<int> HS1 = new HashSet<int>();
            HashSet<int> HS2 = new HashSet<int>();
            for (int i = 0; i < a1.Length;i++)
            {
                L1.Add(a1[i]);
                HS1.Add(a1[i]);
                L2.Add(a2[i]);
                HS2.Add(a2[i]);
            }
            Console.WriteLine("Set1: "+String.Join(" ",HS1));
            Console.WriteLine("List1: " + String.Join(" ", L1));
            Console.WriteLine("Set2: " + String.Join(" ", HS2));
            Console.WriteLine("List2: " + String.Join(" ", L2));
        }
    }
}
