
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C032
    {
        public static void C032Main()
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N < 0 || N > 1000)
            {
                return;
            }

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;


            for (int i = 0; i < N; i++)
            {
                line = System.Console.ReadLine();
                int v = Convert.ToInt32(line.Split(' ')[0]);
                int p = Convert.ToInt32(line.Split(' ')[1]);

                if (v < 0 || v > 3)
                {
                    return;
                }

                if (p < 10 || p > 10000 || p % 10 != 0)
                {
                    return;
                }

                //if (p < 100)
                //{
                //    continue;
                //}

                // decimal temp = Math.Floor(p / 100);

                switch (v)
                {
                    case 0:
                        n1 = n1 + p;
                        break;
                    case 1:
                        n2 = n2 + p;
                        break;
                    case 2:
                        n3 = n3 + p;
                        break;
                    case 3:
                        n4 = n4 + p;
                        break;
                    default:
                        break;
                }
            }

            n1 = Convert.ToInt32(Math.Floor(n1 / 100.0) * 5);
            n2 = Convert.ToInt32(Math.Floor(n2 / 100.0) * 3);
            n3 = Convert.ToInt32(Math.Floor(n3 / 100.0) * 2);
            n4 = Convert.ToInt32(Math.Floor(n4 / 100.0) * 1);

            Console.WriteLine(n1 + n2 + n3 + n4);
        }
    }
}
