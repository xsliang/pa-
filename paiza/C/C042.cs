using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C042
    {
        public static void C042Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N >= 2 && N <= 20)
                {
                    string[,] result = new string[N, N];

                    for (int i = 0; i < N * (N - 1) / 2; i++)
                    {
                        line = System.Console.ReadLine();
                        int w = Convert.ToInt32(line.Split(' ')[0]);
                        int l = Convert.ToInt32(line.Split(' ')[1]);
                        if (w == l)
                        {
                            return;
                        }
                        result[w - 1, l - 1] = "W";
                        result[l - 1, w - 1] = "L";
                    }


                    for (int i = 0; i < N; i++)
                    {
                        List<string> a = new List<string>();
                        for (int j = 0; j < N; j++)
                        {
                            if (string.IsNullOrEmpty(result[i, j]))
                            {
                                a.Add("-");
                            }
                            else
                            {
                                a.Add(result[i, j]);
                            }

                        }
                        System.Console.WriteLine(string.Join(" ", a.ToArray()));
                    }




                }
            }
            catch
            {
            }
        }
    }
}
