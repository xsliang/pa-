// D016:N文字目まで出力

//半角アルファベットで構成された文字列 S と正の整数 N 入力されます。

//1文字目から N 文字目までを出力して下さい。

//例えば

//    abcdefg
//    4

//と入力された場合

//    abcd

//と出力して下さい。

using System;
public class D016
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        if (line1.Length >= 1 && line1.Length <= 100 &&
        Convert.ToInt32(line2) >= 1 && Convert.ToInt32(line2) <= line1.Length)
        {
            int n = Convert.ToInt32(line2);
            System.Console.WriteLine(line1.Substring(0, n));
        }
    }
}
