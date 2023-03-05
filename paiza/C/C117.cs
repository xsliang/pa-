using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C117
    {
        public static void C117Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line.Split(' ')[0]);
            int M = int.Parse(line.Split(' ')[1]);
            if (N >= 1 && N <= 1000 && M >= 1 && M <= 12)
            {
                line = Console.ReadLine();
                int A = int.Parse(line.Split(' ')[0]);
                int B = int.Parse(line.Split(' ')[1]);
                int C = int.Parse(line.Split(' ')[2]);
                if (A >= 1 && A <= 10000 && B >= 1 && B <= 10000 && C >= 1 && C <= 500)
                {
                    int count = 0;
                    for (int i = 0; i < N; i++)
                    {
                        line = Console.ReadLine();
                        int R = int.Parse(line);
                        if (R >= 1 && R <= 1200)
                        {
                            int temp = C * R - A - B * M;
                            if (temp < 0)
                            {
                                count++;
                            }
                        }
                    }
                    Console.WriteLine(count);
                }
            }
        }
    }
}
