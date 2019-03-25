using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    class B013
    {
        public static void B013Main()
        {
            try
            {
                var line1 = System.Console.ReadLine();

                int a = Convert.ToInt32(line1.Split(' ')[0]);
                int b = Convert.ToInt32(line1.Split(' ')[1]);
                int c = Convert.ToInt32(line1.Split(' ')[2]);

                line1 = System.Console.ReadLine();
                int N = Convert.ToInt32(line1);
                if (a >= 1 && a <= 30 && b >= 1 && b <= 30 && c >= 1 && c <= 30 &&
                    N >= 1 && N <= 180)
                {
                    string[] time = new string[N];

                    for (int i = 0; i < N; i++)
                    {
                        line1 = System.Console.ReadLine();

                        int h = Convert.ToInt32(line1.Split(' ')[0]);
                        int m = Convert.ToInt32(line1.Split(' ')[1]);

                        if (h < 6 || h > 8 || m < 0 || N > 59)
                        {
                            return;
                        }
                        else
                        {
                            time[i] = line1;
                        }
                    }

                    int mustH = 8;
                    int mustM = 59;

                    mustM = mustM - c - b;

                    if (mustM < 0)
                    {
                        mustH = mustH - 1;
                        mustM = 60 + mustM;
                    }

                    for (int i = N - 1; i >= 0; i--)
                    {
                        string strTime = time[i];
                        int h = Convert.ToInt32(strTime.Split(' ')[0]);
                        int m = Convert.ToInt32(strTime.Split(' ')[1]);

                        if (h <= mustH && m <= mustM)
                        {
                            mustH = h;
                            mustM = m;
                            break;
                        }
                    }

                    mustM = mustM - a;
                    if (mustM < 0)
                    {
                        mustH = mustH - 1;
                        mustM = 60 + mustM;
                    }

                    Console.WriteLine("{0,2:D2}:{1,2:D2}", mustH, mustM);
                }
            }
            catch
            {
            }

        }
    }
}
