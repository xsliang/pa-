using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C056
    {
        public static void C056Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                if (line.Split(' ').Length == 2)
                {
                    int N = Convert.ToInt32(line.Split(' ')[0]);
                    int M = Convert.ToInt32(line.Split(' ')[1]);
                    List<int> number = new List<int>();
                    if (N >= 1 && N <= 100 && M >= 0 && M <= 100)
                    {
                        for (int i = 0; i < N; i++)
                        {
                            line = System.Console.ReadLine();
                            if (line.Split(' ').Length == 2)
                            {
                                int a = Convert.ToInt32(line.Split(' ')[0]);
                                int b = Convert.ToInt32(line.Split(' ')[1]);

                                if (a >= 0 && a <= 100 && b >= 0 && b <= 15)
                                {
                                    if (a - (5 * b) >= M)
                                    {
                                        number.Add(i + 1);
                                    }
                                    else if (M == 0)
                                    {
                                        number.Add(i + 1);
                                    }
                                }
                            }

                        }

                        foreach (var item in number)
                        {
                            System.Console.WriteLine(item);
                        }
                    }
                }
            }
            catch
            {
            }


        }
    }
}
