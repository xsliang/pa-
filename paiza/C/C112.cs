using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C112
    {
        public static void C112Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            int min = 0;
            int max = 0;
            for (int i = 0; i < N; i++)
            {
                var line2 = Console.ReadLine();
                int s = int.Parse(line2.Split(' ')[0]);
                int f = int.Parse(line2.Split(' ')[1]);
                int t = int.Parse(line2.Split(' ')[2]);

                if (s >= 1 && s <= 23 && f >= 1 && f <= 23 && t >= 1 && t <= 23)
                {
                    int sum = s + f + (24 - t);

                    if (i == 0)
                    {
                        min = sum;
                        max = sum;
                    }
                    else
                    {
                        if (min > sum)
                        {
                            min = sum;
                        }
                        if (max < sum)
                        {
                            max = sum;
                        }
                    }

                }

            }
            Console.WriteLine(min);
            Console.WriteLine(max);
        }
    }
}

