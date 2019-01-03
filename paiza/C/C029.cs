
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C029
    {
        public static void C029Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                // 連休の日数
                int M = Convert.ToInt32(line.Split(' ')[0]);
                // 旅行の日数
                int N = Convert.ToInt32(line.Split(' ')[1]);

                if (M < 1 || N < 1 || M > 30 || N > 30 || N > M)
                {
                    return;
                }

                List<string> data = new List<string>();

                int first = 0;

                for (int i = 0; i < M; i++)
                {
                    var line2 = System.Console.ReadLine();
                    int a = Convert.ToInt32(line2.Split(' ')[0]);
                    int b = Convert.ToInt32(line2.Split(' ')[1]);

                    if (a < 1 || a > 30)
                    {
                        return;
                    }

                    if (i == 0)
                    {
                        first = a;
                    }
                    else
                    {
                        if (first + 1 != a)
                        {
                            return;
                        }
                        first = a;
                    }

                    if (b < 0 || b > 100)
                    {
                        return;
                    }

                    data.Add(line2);
                }

                if (data.Count != M)
                {
                    return;
                }

                int resultB = 0;
                int resultData = 0;

                for (int i = 0; i < M; i++)
                {
                    if (i + N >= M)
                    {
                        break;
                    }

                    int resultA = 0;
                    for (int j = 0; j < N; j++)
                    {
                        resultA = resultA + Convert.ToInt32(data[i + j].Split(' ')[1]);
                    }

                    if (i == 0)
                    {
                        resultB = resultA;
                        resultData = Convert.ToInt32(data[i].Split(' ')[0]);
                    }
                    else if (resultB > resultA)
                    {
                        resultB = resultA;
                        resultData = Convert.ToInt32(data[i].Split(' ')[0]);
                    }
                }

                System.Console.WriteLine(resultData + " " + (resultData + N - 1).ToString());
            }
            catch
            {
            }
        }
    }
}
