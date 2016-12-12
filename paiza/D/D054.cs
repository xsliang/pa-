//今日はみんなで棒状のチョコレートお菓子を持ち寄るパーティーをします。このお菓子が合計で 11 本以上あればパーティーが開催できます。

//このお菓子の 1 本は数字の "1" で表され、本数分だけ "1" が連続する文字列が与えられるので、パーティーが開催できれば "OK"、できなければあと最低で何本用意すればいいかを出力してください。

//例)
//111111111111 → 12 ≧ 11 本 なので OK
//1111111 → 7 < 11 本なので NG、あと 11 - 7 = 4 本 必要

using System;
public class D054
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        try
        {
            if (line.ToString().Length >= 1 && line.ToString().Length <= 20)
            {
                if (line.ToString().Length >= 11)
                {
                    System.Console.WriteLine("OK");
                }
                else
                {
                    int result = 11 - line.ToString().Length;
                    System.Console.WriteLine(result.ToString());
                }
            }
        }
        catch
        {

        }
    }
}
