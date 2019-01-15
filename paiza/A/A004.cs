using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.A
{
    class A004
    {
        public static void A004Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                var main = line.Split(' ');

                int L = Convert.ToInt32(main[0]);
                int n = Convert.ToInt32(main[1]);
                int m = Convert.ToInt32(main[2]);

                if ((L < 2 || L > 10000) || (n < 2 || n > 1000) || (n < 0 || n > 10000))
                {
                    return;
                }

                List<Info> infos = new List<Info>();

                for (int i = 0; i < m; i++)
                {
                    var line1 = System.Console.ReadLine();
                    var main1 = line1.Split(' ');

                    Info info = new Info();
                    info.a = Convert.ToInt32(main1[0]);
                    info.to = info.a + 1;
                    info.b = Convert.ToInt32(main1[1]);
                    info.c = Convert.ToInt32(main1[2]);

                    if ((info.a < 1 || info.a > n - 1) ||
                        (info.b < 1 || info.b > L - 1) ||
                        (info.c < 1 || info.c > L - 1))
                    {
                        return;
                    }

                    if (infos.Where(x => x.a == info.a && x.to == info.to && (x.b == info.b || x.c == info.c || (x.b < info.b && x.c > info.c))).Count() > 0)
                    {
                        return;
                    }

                    infos.Add(info);

                    Info info2 = new Info();
                    info2.a = Convert.ToInt32(main1[0]) + 1;
                    info2.to = info2.a - 1;
                    info2.b = Convert.ToInt32(main1[2]);
                    info2.c = Convert.ToInt32(main1[1]);
                    infos.Add(info2);
                }

                for (int i = 0; i < n; i++)
                {
                    int tempL = 0;
                    bool finished = false;
                    //当前的位置
                    int start = i + 1;
                    do
                    {
                        Info[] temp1 = infos.Where(x => x.a == start && x.b > tempL).OrderBy(y => y.b).ToArray();
                        if (temp1.Length > 0)
                        {
                            tempL = temp1[0].c;
                            start = temp1[0].to;
                        }
                        else
                        {
                            //成功了
                            finished = true;
                            break;
                        }
                    } while (tempL < L);

                    if (finished == true)
                    {
                        if (start == 1)
                        {
                            System.Console.WriteLine(i + 1);
                            return;
                        }
                    }
                }
            }
            catch
            {
            }
        }

        public struct Info
        {
            public int a;
            public int to;
            public int b;
            public int c;
        }
    }
}
