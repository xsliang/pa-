// D007:N倍の文字列

//正の整数 N が標準入力から入力されるので、N 個の「*」を繋げた文字列を出力するプログラムを作成しましょう。

//例えば N = 3の場合

//    ***

//のように出力してください。

using System;
public class D007
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            string[] aryN = new string[n];
            for (int i = 0; i < n; i++)
            {
                aryN[i] = "*";
            }
            System.Console.WriteLine(string.Join("", aryN));
        }
    }
}
