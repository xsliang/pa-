//テスト 9 	ケース 1（大規模データ）通過0.29 秒
//テスト 10 	ケース 1（大規模データ）通過0.46 秒
//if code like this:
// can't pass the big data
//テスト 9 	ケース 1（大規模データ）失敗 （タイムオーバーです）5.00 秒
//テスト 10  ケース 1（大規模データ）失敗 （タイムオーバーです）5.00 秒
//int sum = 0;
//                for (int i = 0; i<M; i++)
//                {
//                    var line2 = System.Console.ReadLine();
//                    if (line2.ToString().Split(' ').Length != N)
//                    {
//                        System.Console.WriteLine(0);
//                        return;
//                    }
//                    int sum1 = 0;
//                    for (int j = 0; j<N; j++)
//                    {
//                        int x = Convert.ToInt32(line2.ToString().Split(' ')[j]);
//                        if (x< -100 || x> 100)
//                        {
//                            System.Console.WriteLine(0);
//                            return;
//                        }

//                        sum1 = sum1 + x;
//                    }
//                    if (sum1>=0)
//                    {
//                        sum = sum + sum1;
//                    }
//                    sum1 = 0;
//                }

using System;
public class B008
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        try
        {
            int N = Convert.ToInt32(line.ToString().Split(' ')[0]);
            int M = Convert.ToInt32(line.ToString().Split(' ')[1]);
            if (N >= 0 && N <= 1000 && M >= 0 && M <= 1000)
            {
                if (N == 0 || M == 0)
                {
                    System.Console.WriteLine(0);
                    return;
                }

                int sum = 0;
                for (int i = 0; i < M; i++)
                {
                    var line2 = System.Console.ReadLine();
                    string[] aryLine2 = line2.ToString().Split(' ');
                    if (aryLine2.Length != N)
                    {
                        System.Console.WriteLine(0);
                        return;
                    }
                    int sum1 = 0;

                    for (int j = 0; j < N; j++)
                    {
                        int x = Convert.ToInt32(aryLine2[j]);
                        if (x < -100 || x > 100)
                        {
                            System.Console.WriteLine(0);
                            return;
                        }

                        sum1 = sum1 + x;
                    }
                    if (sum1 >= 0)
                    {
                        sum = sum + sum1;
                    }
                    sum1 = 0;
                }

                System.Console.WriteLine(sum.ToString());
            }
        }
        catch
        {

        }
    }
}

