using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C054
    {
        public static void C054Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line.Split(' ')[0]);
                int V = Convert.ToInt32(line.Split(' ')[1]);

                int last_t = 0;
                int last_p = 0;
                string yes = "NO";
                if (N >= 2 && N <= 1000 && V >= 1 && V <= 1000)
                {
                    for (int i = 0; i < N; i++)
                    {
                        line = System.Console.ReadLine();
                        int t = Convert.ToInt32(line.Split(' ')[0]);
                        int p = Convert.ToInt32(line.Split(' ')[1]);
                        if (t >= 0 && t <= 10000 && p >= 0 && p <= 10000)
                        {
                            if ((t - last_t)!=0 && (p - last_p) / (t - last_t) >= V)
                            {
                                yes = "YES";
                                break;
                            }
                            else
                            {
                                last_t = t;
                                last_p = p;
                            }
                        }
                    }

                    System.Console.WriteLine(yes);
                }
            }
            catch
            {
            }
        }
    }
}
