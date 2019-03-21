using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    class B010
    {
        public static void B010Main()
        {


            try
            {
                var line1 = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();
                var line3 = System.Console.ReadLine();

                // チーム名T
                string T = line1.Split(' ')[0];

                if (T != "A" && T != "B")
                {
                    return;
                }

                // 背番号U
                int U = Convert.ToInt32(line1.Split(' ')[1]);

                if (U < 1 || U > 11)
                {
                    return;
                }

                int[] Xa = new int[11];
                int[] Xb = new int[11];

                string[] tempa = line2.Split(' ');
                string[] tempb = line3.Split(' ');
                for (int i = 0; i < 11; i++)
                {
                    int tempa_a = Convert.ToInt32(tempa[i]);
                    if (tempa_a < 0 || tempa_a > 110)
                    {
                        return;
                    }
                    else
                    {
                        Xa[i] = tempa_a;
                    }

                    int tempb_b = Convert.ToInt32(tempb[i]);
                    if (tempb_b < 0 || tempb_b > 110)
                    {
                        return;
                    }
                    else
                    {
                        Xb[i] = tempb_b;
                    }
                }
                bool none = true;
                if (T == "A")
                {
                    int second = Xb.OrderByDescending(x => x).ToArray()[1];

                    for (int i = 0; i < 11; i++)
                    {
                        if (Xa[i] > second && Xa[i] > 55 && Xa[i] > Xa[U - 1])
                        {
                            none = false;
                            Console.WriteLine(i + 1);
                        }
                    }
                    if (none == true)
                    {
                        Console.WriteLine("None");
                    }
                }
                else
                {
                    int second = Xa.OrderBy(x => x).ToArray()[1];

                    for (int i = 0; i < 11; i++)
                    {
                        if (Xb[i] < second && Xb[i] < 55 && Xb[i] < Xb[U - 1])
                        {
                            none = false;
                            Console.WriteLine(i + 1);
                        }
                    }
                    if (none == true)
                    {
                        Console.WriteLine("None");
                    }
                }
            }
            catch
            {
            }

        }
    }
}
