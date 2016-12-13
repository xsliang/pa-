// あなたは気象庁のデータ分析の担当者で、8 月の台風の上陸の間隔についてのデータを作るよう求められました。

//サンプルとなる5 個の台風について上陸した日が与えられるので、それぞれ(2 個目以降) について直前の上陸日との間隔日数を出力してください。

//例)
//与えられる入力

//    1
//    5
//    15
//    27
//    28


//期待する出力

//    4
//    10
//    12
//    1

//    ・期待する出力は 4 行からなります。
//・出力の j 行目(1 ≦ j ≦ 4) に、j + 1 番目と j 番目の台風の上陸日の間隔日数を表す整数 g_j を出力してください。
//・出力の最後に改行を入れ、余計な文字、空行を含んではいけません。

//    すべてのテストケースで以下の条件を満たします。

//・ 1 ≦ d1<d2<d3<d4<d5 ≦ 31


using System;
public class D048
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        try
        {
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                var line = System.Console.ReadLine();
                if (Convert.ToInt32(line)<1 || Convert.ToInt32(line) > 31)
                {
                    return;
                }
                if (i > 0)
                {
                    if (a[i - 1] < Convert.ToInt32(line))
                    {
                        a[i] = Convert.ToInt32(line);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    a[i] = Convert.ToInt32(line);
                }

            }

            for (int i = 0; i < 4; i++)
            {
                int result = a[i + 1] - a[i];
                System.Console.WriteLine(result.ToString());
            }

        }
        catch
        { }
    }
}