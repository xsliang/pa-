using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C036
    {
        public static void C036Main()
        {
            var line = System.Console.ReadLine();
            var line2 = System.Console.ReadLine();
            var line3 = System.Console.ReadLine();
            var line4 = System.Console.ReadLine();

            Dictionary<int, int> input = new Dictionary<int, int>();
            int p1 = Convert.ToInt32(line.Split(' ')[0]);
            input.Add(p1, Convert.ToInt32(line3.Split(' ')[p1 - 1]));

            int p2 = Convert.ToInt32(line.Split(' ')[1]);
            input.Add(p2, Convert.ToInt32(line3.Split(' ')[p2 - 1]));

            int p3 = Convert.ToInt32(line2.Split(' ')[0]);
            input.Add(p3, Convert.ToInt32(line3.Split(' ')[p3 - 1]));

            int p4 = Convert.ToInt32(line2.Split(' ')[1]);
            input.Add(p4, Convert.ToInt32(line3.Split(' ')[p4 - 1]));

            int e1 = Convert.ToInt32(line3.Split(' ')[p1 - 1]);
            int e2 = Convert.ToInt32(line3.Split(' ')[p2 - 1]);
            int e3 = Convert.ToInt32(line3.Split(' ')[p3 - 1]);
            int e4 = Convert.ToInt32(line3.Split(' ')[p4 - 1]);

            int f1 = Convert.ToInt32(line4.Split(' ')[0]);
            int f2 = Convert.ToInt32(line4.Split(' ')[1]);

            if (p1 == p2 || p1 == p3 || p1 == p4 || p2 == p3 || p2 == p4 || p3 == p4 ||
                e1 == e2 || e1 == e3 || e1 == e4 || e2 == e3 || e2 == e4 || e3 == e4 || f1 == f2)
            {
                return;
            }

            if (p1 >= 1 && p1 <= 4 && p2 >= 1 && p2 <= 4 && p3 >= 1 && p3 <= 4 && p4 >= 1 && p4 <= 4 &&
                e1 >= 0 && e1 <= 1000 && e2 >= 0 && e2 <= 1000 && e3 >= 0 && e3 <= 1000 && e4 >= 0 && e4 <= 1000 &&
                f1 >= 0 && f1 <= 1000 && f2 >= 0 && f2 <= 1000)
            {
                //e1 = Convert.ToInt32(line3.Split(' ')[p3 - 1]);

                if (input[p1] > input[p2] && input[p3] > input[p4])
                {
                    if ((f1 < f2 && p2 < p4) || (f1 > f2 && p2 > p4))
                    {
                        System.Console.WriteLine(p2);
                        System.Console.WriteLine(p4);
                    }
                    else
                    {
                        System.Console.WriteLine(p4);
                        System.Console.WriteLine(p2);
                    }
                }
                else if (input[p1] > input[p2] && input[p3] < input[p4])
                {
                    if ((f1 < f2 && p2 < p3) || (f1 > f2 && p2 > p3))
                    {
                        System.Console.WriteLine(p2);
                        System.Console.WriteLine(p3);
                    }
                    else
                    {
                        System.Console.WriteLine(p3);
                        System.Console.WriteLine(p2);
                    }
                }
                else if (input[p1] < input[p2] && input[p3] > input[p4])
                {
                    if ((f1 < f2 && p1 < p4) || (f1 > f2 && p1 > p4))
                    {
                        System.Console.WriteLine(p1);
                        System.Console.WriteLine(p4);
                    }
                    else
                    {
                        System.Console.WriteLine(p4);
                        System.Console.WriteLine(p1);
                    }
                }
                else if (input[p1] < input[p2] && input[p3] < input[p4])
                {
                    if ((f1 < f2 && p1 < p3) || (f1 > f2 && p1 > p3))
                    {
                        System.Console.WriteLine(p1);
                        System.Console.WriteLine(p3);
                    }
                    else
                    {
                        System.Console.WriteLine(p3);
                        System.Console.WriteLine(p1);
                    }
                }
            }

        }
    }
}
