//あなたはお月見の準備をしています。子供 2 人にいくつお月見だんごがほしいかをたずねますが、やんちゃな子は明らかに食べきれない数のだんごを要求してきます。

//付き合いきれないのであなたは 5 より大きい数字を要求された場合には 5 個しか与えないことにしました。もちろん 5 以下の場合にはその数のだんごを与えます。

//必要なだんごの数を求めましょう。

//例)
//ほしいだんごの数:
//子供 1 → 3 個
//子供 2 → 50 個

//用意するだんごの数:
//3 + 5 (50 > 5 のため) = 8 個

//これは入力例 1 に対応しています。

//    すべてのテストケースで以下の条件を満たします。

//・1 ≦ d_1, d_2 ≦ 1,000 

using System;
public class D050
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        try
        {
            int d1 = Convert.ToInt32(Convert.ToString(line).Split(' ')[0]);
            int d2 = Convert.ToInt32(Convert.ToString(line).Split(' ')[1]);
            if (1 <= d1 && d1 <= 1000 && 1 <= d2 && d2 <= 1000)
            {
                if (d1 > 5)
                {
                    d1 = 5;
                }
                if (d2 > 5)
                {
                    d2 = 5;
                }

                System.Console.WriteLine(d1 + d2);
            }
        }
        catch
        {

        }
    }
}
