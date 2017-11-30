using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace zadanie6_7657
{
    class Program
    {
        static bool VseHorowo(String s)
        {
            if (String.IsNullOrEmpty(s)) return false;
            for (int i = 0; i < s.Length; i++)
            {
                if (!char.IsDigit(s[i]))                
                    return false;     
            }
            return true;
        }
        static void Main(string[] args)
        {
            for (int i = 1; i < 8; i++)
            {
                String r = "task7657\\test" + i + ".csv";
                int b = 0;
                try
                {
                    using (StreamReader str = new StreamReader(r))
                    {
                        if (!str.EndOfStream)
                        {
                            List<Point> L1 = new List<Point>();
                            while (!str.EndOfStream)
                            {
                                Point P1 = new Point();
                                String a = str.ReadLine();
                                if (a == null || !a.Contains(";"))
                                {
                                    b++;
                                    continue;
                                }
                                String[] a1 = a.Split(';');
                                if (a1.Length != 3 || !VseHorowo(a1[0]) || !VseHorowo(a1[1]) || String.IsNullOrEmpty(a1[2]))
                                {
                                    b++;
                                    continue;
                                }
                                P1.X = int.Parse(a1[0]);
                                P1.Y = int.Parse(a1[1]);
                                P1.Color = a1[2];
                                L1.Add(P1);
                            }
                            L1.Reverse();
                            Dictionary<Point,int> Dct1 = new Dictionary<Point,int>();
                            foreach (Point x in L1)
                            {
                                if (Dct1.ContainsKey(x))
                                {
                                    Dct1[x]++;
                                }
                                else
                                {
                                    Dct1.Add(x, 1);
                                }
                            }
                            foreach (var x in Dct1)
                            {
                                Console.WriteLine(x.Key +"Замен: "+x.Value);
                            }
                            Console.WriteLine($"Некорректных записей: {b}");
                        }
                        else
                        {
                            Console.WriteLine("Файл пуст");
                        }
                    }
                }                
                catch (FileNotFoundException ex)
                {
                    Console.WriteLine("Файл не найден");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
