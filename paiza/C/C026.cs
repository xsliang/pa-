

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C026
    {
        public static void C026Main()
        {
            
            
            try
            {
                int number = 0;
                int weight = 0;
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line.Split(' ')[0]);
                if (N < 3 || N > 100)
                {
                    return;
                }
                int S = Convert.ToInt32(line.Split(' ')[1]);
                if (S < 1 || S > 100)
                {
                    return;
                }
                int p = Convert.ToInt32(line.Split(' ')[2]);
                if (p < 0 || p > 10)
                {
                    return;
                }
                for (int i = 0; i < N; i++)
                {
                    var line2 = System.Console.ReadLine();
                    int m = Convert.ToInt32(line2.Split(' ')[0]);
                    int s = Convert.ToInt32(line2.Split(' ')[1]);
                    if (m < 1 || m > 100 || s < 1 || s > 100)
                    {
                        return;
                    }
                    if ((S - p) <= s && s <= (S + p))
                    {
                        if (weight < m)
                        {
                            weight = m;
                            number = i + 1;
                        }
                    }
                }

                if (number > 0)
                {
                    System.Console.WriteLine(number);
                }
                else
                {
                    System.Console.WriteLine("not found");
                }

            }
            catch
            {
            }

        }
    }
}
