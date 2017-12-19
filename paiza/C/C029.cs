// C029:旅行の計画
//あなたは連休に N 日間の旅行にいく計画を立てています。降水確率の予報を見て、 N 日間の降水確率の平均が最も低くなる日程を選びます。
//例)
//連休: 7 日間(19 日から 25 日)
//旅行日数: 3 日間
//各日付の降水確率: 上図

//→旅行日程: 22日 - 24日

//このような形で連休の日数、旅行の日数および各日付の降水確率が与えられたとき、 降水確率の平均が最も低くなる日程を求めてください。

//なおこのような日程が複数あった場合はそのうち最も早いものを出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C029
    {
        public static void Main()
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
            catch (Exception ex)
            {
            }
        }
    }
}
