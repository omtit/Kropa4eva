using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1_8787
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(7991);
            Console.WriteLine();
            Task7991.P1234();
            Console.WriteLine();

            Console.WriteLine(2321);
            Console.WriteLine();
            Task2321.P123();
            Console.WriteLine();

            Console.WriteLine(5053);
            Console.WriteLine();
            Task5053.P123();
            Console.WriteLine();

            Console.WriteLine(8418);
            Console.WriteLine();
            Task8418.P123();
            Console.WriteLine();

            Console.WriteLine(9279);
            Console.WriteLine();
            Task9279.P123456();
            Console.WriteLine();

            Console.WriteLine(3657);
            Console.WriteLine();
            Task3657.P123456();
            Console.WriteLine();

            Console.WriteLine(6599);
            Console.WriteLine();
            Task6599.P();
            Console.WriteLine();

            Console.WriteLine(1223);
            Console.WriteLine();
            Task1223.P();
            Console.WriteLine();

            Console.WriteLine(3940);
            Console.WriteLine();
            Task3940.P();
            Console.WriteLine();

            Console.WriteLine(8311);
            Console.WriteLine();
            Task8311.PP();
            Console.WriteLine();

            Console.WriteLine(3134);
            Console.WriteLine();
            Task3134.PP();
            Console.WriteLine();

            Console.WriteLine(9774);
            Console.WriteLine();
            Task9774.P();
            Console.WriteLine();

            Console.WriteLine(9711);
            Console.WriteLine();
            Task9711.P();
            Console.WriteLine();

            Console.WriteLine(3333);
            Console.WriteLine();
            Task3333.PP();
            Console.WriteLine();

            Console.WriteLine(9271);
            Console.WriteLine();
            Task9271.PP();
            Console.WriteLine();

            Console.WriteLine(4497);
            Console.WriteLine();
            Task4497.PP();
            Console.WriteLine();

            Console.WriteLine(8820);
            Console.WriteLine();
            Task8820.P();
            Console.WriteLine();

            Console.WriteLine(3218);
            Console.WriteLine();
            Task3218.PP();
            Console.WriteLine();

            Console.WriteLine(7703);
            Console.WriteLine();
            Task7703.PP();
            Console.WriteLine();
        }
    }
    #region 7991
    class Task7991
    {
        static String LF(double[] a)
        {
            List<double> L1 = new List<double>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > -3 && a[i] < 5)
                {
                    L1.Add(a[i]);
                }
            }
            return String.Join(" ", L1);
        }

        public static void P1234()
        {
            double[] a1 = new double[] { 6.35, 2.7, 5.08 };
            Console.WriteLine(LF(a1));
            double[] a2 = new double[] { 4.71, 2.59, -18.55 };
            Console.WriteLine(LF(a2));
            double[] a3 = new double[] { 19.99, -1.57, 2.75 };
            Console.WriteLine(LF(a3));
            double[] a4 = new double[] { -2.28, 16.92, 6.14 };
            Console.WriteLine(LF(a4));
        }
    }
    #endregion
    #region 2321
    class Task2321
    {
        static String AB(int a, int b)
        {
            List<int> L1 = new List<int>();
            if (a < b)
            {
                while (a <= b)
                {
                    L1.Add(a++);
                }
            }
            else
            {
                while (a >= b)
                {
                    L1.Add(a--);
                }
                L1.Reverse();
            }
            return String.Join(" ", L1);

        }
        public static void P123()
        {
            Console.WriteLine(AB(8, 13));
            Console.WriteLine(AB(691, 702));
            Console.WriteLine(AB(23, 11));
        }
    }
    #endregion
    #region 5053
    class Task5053
    {
        static String AB(int a, int b)
        {
            List<int> L1 = new List<int>();
            if (a < b)
            {
                while (a <= b)
                {
                    L1.Add(a++);
                }
            }
            else
            {
                while (a >= b)
                {
                    L1.Add(a--);
                }
            }
            return String.Join(" ", L1);

        }
        public static void P123()
        {
            Console.WriteLine(AB(8, 13));
            Console.WriteLine(AB(691, 702));
            Console.WriteLine(AB(23, 11));
        }
    }
    #endregion
    #region 8418
    class Task8418
    {
        static String D(int a)
        {
            if (a < 0)
            {
                throw new ArgumentException("Значение X должно быть положительным");
            }
            List<int> L1 = new List<int>();
            for (int i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    L1.Add(i);
                }
            }
            return String.Join(" ", L1);

        }
        public static void P123()
        {
            int[] a = new int[] { 6, 385, -9 };
            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    Console.WriteLine(D(a[i]));
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion
    #region 9279
    class Task9279
    {
        static String LF(String a)
        {
            if (a.Length != 2)
            {
                throw new ArgumentException("Вводимая строка должна содержать ровно 2 символа");
            }
            List<int> L1 = new List<int>();
            string s = "abcdacadbacdaabaadc";
            int i = 0;
            int j = s.IndexOf(a);
            if (j == -1)
            {
                return String.Format("Строка s не содержит комбинацию");
            }
            while (i < s.Length - 1)
            {
                if (s[i] == a[0] && s[i + 1] == a[1])
                {
                    L1.Add(i);
                }
                i++;
            }
            return String.Join(" ", L1);
        }
        public static void P123456()
        {
            String[] a = new String[] { "ab", "bc", "ac", "xz", "cde", "a" };
            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    Console.WriteLine(LF(a[i]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion
    #region 3657
    class Task3657
    {
        static String LF(String b)
        {
            string a = "jijjbjjcidihddbjbcjdjhjdjijjahahdhjcfjcghcjgjgbjdcijibgjbajhdbjhjacgbdijjbdjdjhjigjjgigjahbjjihgiccaaijjajjjijjiiidfgfhgbjjdjajjfhdjajffjhbjghjijabfihbgjjibdjbcgjhjjjbdjibjhjccjjjfjicjjjdjdjjjfjhjhjffjjfbfhhfdhjdjibdjgadcajdjdajhjcijghgijjgchdjadjjdgfbibjjaaijfjcjgjdafcjbhabiggigdccjccjghjadaacffjajicfdijfacjcdfjhhigbjhhhjcbhhfcicbadjgjjddbhhfjfhgjjbbgijijcjgjjccdjifcjjcgfjjhcdhcabggfiabchjjfbbdbjjjgfcdiadcfffjjgbdjjdahhjjaijjdjfddhahjabaacdhahafghjaajchjcdjaihijjdcajhdigiaafhjiijgjfhdjijigjchbhdabacijcajjhfjfgjahffjbahfjjdjgiiahjajjdjfggihajjgjffgjjdhajjjjhcjdjbgjjdjbjjaadhdfhdijaijhaijfhibdadibjcjdfbjigjcjhaijfghbfcjfjagchjhcadjbdbbjhjgdhbjjjfjihchjahgjajgaficjjfjjdjhjjdjajaadgfbdccgjhhajicjdahcjjajjgjjjijbijigbjbaihjgiahjfhjbjjajbjcfcjcajjdjcghicdjdjgbcjijfcacjccjijjffdjigjjhjfcdhbbjhgjfhjgajjgjhdiachhjjjdajjidgbigicjdbjjhdgjihdjcjgijjdgfjgjaaghjjgddjhcfddaajjbjbiahijdajjjbfaachjgidgcjjahfdhcabdfjhjjaifhjjbbgjchjicjjcajhbbcjbgjjjabhdgjcggajhhddbgajjfjajfcccifaibagjcbfjaihdhhbdfijjf";
            if (b.Length != 1)
            {
                throw new ArgumentException("Нужно ввести ровно один символ");
            }
            if (a.IndexOf(b) == -1)
            {
                return String.Format("Строка не содержит комбинацию");
            }
            List<int> L1 = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == b[0])
                {
                    L1.Add(i);
                }
            }
            return String.Join(" ", L1);

        }
        public static void P123456()
        {
            String[] a = new String[] { "a", "b", "j", "z", "xy", "" };
            String[] b = new String[] {"28 30 57 65 88 99 100 104 125 132 145 218 221 226 244 256 257 267 273 290 292 293 298" +
                " 307 333 382 388 407 421 426 436 439 441 442 446 448 453 454 462 470 477 478 501 503 508 517 523 533 536 546 558 " +
                "577 578 587 591 599 616 628 635 659 663 666 682 684 685 697 703 708 725 731 740 749 771 804 812 820 856 857 871 " +
                "872 879 884 890 891 902 908 916 934 946 955 963 968 976 979 986","4 14 16 46 53 56 61 68 73 90 120 138 146 150 155" +
                " 158 166 170 203 214 251 253 271 274 318 325 332 341 351 352 383 389 395 396 398 416 440 498 502 522 568 574 597 602 " +
                "608 622 638 640 641 648 689 717 722 724 737 742 764 794 795 826 833 875 877 888 909 922 923 937 938 941 947 961 978 983 992",
            "0 2 3 5 6 15 18 20 22 24 26 27 34 37 42 44 47 51 55 58 62 64 71 72 75 77 79 82 83 87 91 92 102 103 105 106 107 109 110 121 122 " +
            "124 126 127 131 133 136 139 142 144 152 153 157 161 163 164 165 168 171 173 176 177 178 180 183 184 185 187 189 190 191 193 195" +
            " 197 200 201 210 212 216 222 224 227 229 232 237 238 243 246 247 254 255 259 261 263 265 270 283 286 289 297 299 305 309 313 319 " +
            "323 335 337 338 345 349 350 355 357 359 361 362 366 370 371 375 376 392 393 399 400 401 413 414 418 419 424 425 428 429 431 438 " +
            "452 455 458 461 466 467 471 481 484 486 490 492 495 506 509 510 513 516 521 526 527 529 535 537 538 540 547 548 550 554 555 559 " +
            "560 561 562 565 567 570 571 573 575 576 586 589 593 603 605 609 612 614 618 625 627 632 637 642 644 649 650 651 653 658 662 664 " +
            "670 671 673 674 676 678 679 681 683 694 698 701 706 707 709 710 712 713 714 716 719 723 728 733 736 738 739 741 743 747 750 751 " +
            "753 760 762 766 768 773 776 778 779 783 786 787 789 796 799 802 805 806 808 816 817 818 821 822 831 834 835 839 843 845 848 849 " +
            "853 855 860 861 865 873 874 876 882 885 886 887 894 900 901 912 914 915 920 921 925 928 931 932 935 940 943 944 945 951 956 964 " +
            "965 967 969 981 985 996 997","Строка не содержит комбинацию"};

            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    if (b[i] == LF(a[i]))
                    {
                        Console.WriteLine("Задача решена верно");
                    }
                    else
                    {
                        Console.WriteLine("Задача решена неверно");
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion
    #region 6599
    class Task6599
    {
        static String Change(String a)
        {
            char quote = '"';
            char LeftB = '[';
            char RightB = ']';
            int p = 0;
            List<String> L1 = new List<string>();
            for (int i = 0; i <= a.Length - 1; i++)
            {
                string c = a.Substring(i, 1);
                if (a[i] == LeftB || a[i] == RightB)
                {
                    L1.Add("\\" + a[i]);
                }
                else
                {
                    if (a[i] == quote)
                    {
                        if (p % 2 == 0)
                        {
                            L1.Add("[");
                        }
                        else
                        {
                            L1.Add("]");
                        }
                        p++;
                    }
                    else
                    {
                        L1.Add("" + a[i]);
                    }
                }
            }
            return String.Join("", L1);
        }
        public static void P()
        {
            String[] a = new String[] { "a", "\"b\"", "\"c", "d\"", "\"e\"e", "f\"f\"f", "\"abc\" \"defgh\" \"i\" \"jklm\"", "abc\" \"def\" \"ghi\" \"jk\" \"lm\"", "", "\"[abc\"def] \"[ghijklm]\"" };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(Change(a[i]));
            }
        }
    }
    #endregion
    #region 1223
    class Task1223
    {
        static String Reverse(String a)
        {
            String[] a1 = a.Split(' ');
            List<String> L1 = new List<string>();
            for (int i = 0; i < a1.Length; i++)
            {
                L1.Add(a1[i]);
            }
            L1.Reverse();
            return String.Join(" ", L1);
        }
        public static void P()
        {
            String[] a = new String[] { "q w e r t y", "q w e r t y q w e r", "as df gh jk" };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(Reverse(a[i]));
            }
        }
    }
    #endregion
    #region 3940
    class Task3940
    {
        static String MM(String a, String b)
        {
            String[] a1 = a.Split(' ');
            String[] b1 = b.Split(' ');
            if (a1.Length != b1.Length)
            {
                throw new ArgumentException("Размеры массивов должны быть одинаковы");
            }
            List<int> L1 = new List<int>();
            for (int i = 0; i < a1.Length; i++)
            {
                L1.Add(int.Parse(a1[i]) * int.Parse(b1[i]));
            }
            return String.Join(" ", L1);
        }
        public static void P()
        {
            String[] left = new String[] { "1 2 3 4 1", "1 2 3 4 1 3 4 4 4 4", "1 2 3", "1 2 3" };
            String[] right = new String[] { "2 3 4 1 2", "3 4 1 2 3 4 1 2 3 4", "3 4", "3 4 1 2" };

            {
                for (int i = 0; i < left.Length; i++)
                {
                    try
                    {
                        Console.WriteLine(MM(left[i], right[i]));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }
        }
    }
    #endregion
    #region 8311
    class Task8311
    {
        static String Elem(int b, int e, String s)
        {
            String[] s1 = s.Split(' ');
            if (b < 0 || b > s1.Length - 1)
            {
                throw new ArgumentException("Число B должно быть в интервале [0, размер массива)");
            }
            if (e < 0 || e > s1.Length - 1)
            {
                throw new ArgumentException("Число E должно быть в интервале [0, размер массива)");
            }
            List<String> L1 = new List<string>();
            if (b <= e)
            {
                while (b <= e)
                {
                    L1.Add(s1[b]);
                    b++;
                }
            }
            else
            {
                while (e <= b)
                {
                    L1.Add(s1[e]);
                    e++;
                }
            }
            return String.Join(" ", L1);
        }
        public static void PP()
        {
            int[] b = new int[] { 0, 1, 2, 3, 2, 8, 11, -1, 8 };
            int[] e = new int[] { 3, 3, 3, 10, 2, 2, 8, 5, 50 };
            String[] data = new String[] { "z x c v b", "z x c v b", "z x c v b", "z x c v b a s d f g h", "z x c v b a s d f g h", "z x c v b a s d f g h", "z x c v b a s d f g h", "z x c v b a s d f g h", "z x c v b a s d f g h" };
            for (int i = 0; i < b.Length; i++)
            {
                try
                {
                    Console.WriteLine(Elem(b[i], e[i], data[i]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion
    #region 3134
    class Task3134
    {
        static String ChangePlaces(int p, int q, String a)
        {
            String[] a1 = a.Split(' ');
            if (p > a1.Length - 1 || p < 0)
            {
                throw new ArgumentException("Число P должно быть в интервале [0, размер массива)");
            }

            if (q > a.Length - 1 || q < 0)
            {
                throw new ArgumentException("Число Q должно быть в интервале [0, размер массива)");
            }
            String e = a1[p];
            a1[p] = a1[q];
            a1[q] = e;
            List<String> L1 = new List<string>();
            for (int i = 0; i < a1.Length; i++)
            {
                L1.Add(a1[i]);
            }
            return String.Join(" ", L1);
        }
        public static void PP()
        {
            int[] p = new int[] { 0, 2, 4, -1, 2, 19, 1 };
            int[] q = new int[] { 3, 5, 2, 5, 17, 2, -5 };
            String s = "q w e r t y";
            for (int i = 0; i < p.Length; i++)
            {
                try
                {
                    Console.WriteLine(ChangePlaces(p[i], q[i], s));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion
    #region 9774
    class Task9774
    {
        static String Pr(int m, String s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                throw new FormatException("Неверный формат");
            }
            String[] a = s.Split(' ');
            List<int> L1 = new List<int>();
            for (int i = 0; i < a.Length; i++)
            {
                L1.Add(m * int.Parse(a[i]));
            }
            return String.Join(" ", L1);
        }
        public static void P()
        {
            int[] m = new int[] { 31, -3, 11, 73 };
            String[] data = new String[] { "9 8 7 6 5 4", "9 8 7 6 5 4", "98 76 54", " " };
            for (int i = 0; i < m.Length; i++)
            {
                try
                {
                    Console.WriteLine(Pr(m[i], data[i]));
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion
    #region 9711
    class Task9711
    {
        static String MoveForOne(String s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                throw new FormatException("Строка пуста");
            }
            String[] s1 = s.Split(' ');
            List<String> L1 = new List<string>();
            L1.Add(s1[s1.Length - 1]);
            for (int i = 0; i < s1.Length - 1; i++)
            {
                L1.Add(s1[i]);
            }
            return String.Join(" ", L1);
        }
        public static void P()
        {
            String[] data = new String[] { "q w e r t y", "a s d f g h j k l m", "zx cv bn m", "" };
            for (int i = 0; i < data.Length; i++)
            {
                try
                {
                    Console.WriteLine(MoveForOne(data[i]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion
    #region 3333
    class Task3333
    {
        static String Move(int k)
        {
            String s = "q w e r t y";
            String[] s1 = s.Split(' ');
            int i = 0;
            List<String> L1 = new List<string>();
            while (i < s1.Length)
            {
                if (k >= 0)
                {
                    int k1 = s1.Length - k % s1.Length;
                    L1.Add(s1[(i + k1) % s1.Length]);
                }
                else
                {
                    int k1 = k % s1.Length + s1.Length;
                    L1.Add(s1[(i + k1) % s1.Length]);
                }
                i++;
            }
            return String.Join(" ", L1);
        }
        public static void PP()
        {
            int[] s = new int[] { 1, 3, 4, 8, 99, -2, -9 };
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(Move(s[i]));
            }
        }
    }
    #endregion
    #region 9271
    class Task9271
    {
        static String DelMin(String s1)
        {
            if (String.IsNullOrWhiteSpace(s1))
            {
                throw new FormatException("Строка пуста");
            }
            String[] a1 = s1.Split(' ');
            int k = int.Parse(a1[0]);
            for (int i = 1; i < a1.Length; i++)
            {
                int a2 = int.Parse(a1[i]);
                if (a2 < k)
                {
                    k = a2;
                }
            }
            List<int> L1 = new List<int>();
            for (int i = 0; i < a1.Length; i++)
            {
                L1.Add((int.Parse(a1[i]) - k));
            }
            return String.Join(" ", L1);
        }
        public static void PP()
        {
            String[] a = new String[] { "1 2 3 4 1 2", "3 4 1 2 3 4 1 2 3 1 2", "4 2 3 4 3 2", "4 4 4 4 4 3 2 1", "4 4 4 4", "4 3" };
            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    Console.WriteLine(DelMin(a[i]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion
    #region 4497
    class Task4497
    {
        static String Change(int x, int y, String s1)
        {
            if (String.IsNullOrWhiteSpace(s1))
            {
                throw new FormatException("Строка пуста");
            }
            List<int> L1 = new List<int>();
            String[] a1 = s1.Split(' ');
            for (int i = 0; i < a1.Length; i++)
            {
                if (int.Parse(a1[i]) == x)
                {
                    L1.Add(y);
                }
                else
                {
                    L1.Add(int.Parse(a1[i]));
                }
            }
            return String.Join(" ", L1);
        }
        public static void PP()
        {
            int[] x = new int[] { 1, 3, 5 };
            int[] y = new int[] { 33, 55, 1 };
            String data = "1 2 3 4 1 2";
            for (int i = 0; i < x.Length; i++)
            {
                try
                {
                    Console.WriteLine(Change(x[i], y[i], data));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion
    #region 8820
    class Task8820
    {
        static String Reverse(String a)
        {
            String[] a1 = a.Split(' ');
            List<String> L1 = new List<string>();
            for (int i = 0; i < a1.Length; i++)
            {
                L1.Add(a1[i]);
            }
            L1.Reverse();
            return String.Join(" ", L1);
        }
        public static void P()
        {
            String[] a = new String[] { "q w e r t y", "as df ghr", "q w e r t y a s d f g" };
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(Reverse(a[i]));
            }
        }
    }
    #endregion
    #region 3218
    class Task3218
    {
        static String Sort(String s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                throw new FormatException("Строка пуста");
            }
            String[] s1 = s.Split(' ');
            List<int> L1 = new List<int>();
            for (int i = 0; i < s1.Length; i++)
            {
                L1.Add(int.Parse(s1[i]));
            }
            L1.Sort();
            return String.Join(" ", L1);
        }
        public static void PP()
        {
            String[] s = new String[] { "4 1 1 1", "1 4 2 1", "3 4 1 5", "1 2 3 4 1 2", "1 2 3 4 1 2 3 4 1 2 3" };
            for (int i = 0; i < s.Length; i++)
            {
                try
                {
                    Console.WriteLine(Sort(s[i]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion
    #region 7703
    class Task7703
    {
        static String Amount(String s)
        {
            if (String.IsNullOrWhiteSpace(s))
            {
                throw new FormatException("Строка пуста");
            }
            String[] a1 = s.Split(' ');
            int[] a2 = new int[a1.Length];
            int[] a3 = new int[a1.Length];
            List<int> L1 = new List<int>();
            for (int i = 0; i < a1.Length; i++)
            {
                a2[i] = int.Parse(a1[i]);
            }
            for (int i = 0; i < a2.Length; i++)
            {
                int amount = 0;
                int c = a2[i];
                for (int j = 0; j < a2.Length; j++)
                {
                    if (c == a2[j])
                    {
                        amount++;
                    }
                }
                a3[i] = amount;
                L1.Add(a3[i]);
            }
            return String.Join(" ", L1);
        }
        public static void PP()
        {
            String[] data = new String[] { "1 2 3 4 1 2", "1 2 3 4 1 2 3 4 1 2 3", "3 2 2 2 2 2", "4 4 4 4 4 4" };
            for (int i = 0; i < data.Length; i++)
            {
                try
                {
                    Console.WriteLine(Amount(data[i]));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
    #endregion

}


