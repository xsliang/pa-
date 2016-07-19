// D012:絶対値を求めよ

//-100から100までの整数 n が与えられるので、絶対値を出力して下さい。

//例えば

//    -10

//と入力された場合

//    10

//と出力して下さい。

using System;
public class D012
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= -100 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            if (n < 0)
            {
                n = 0 - n;
            }
            System.Console.WriteLine(n);
        }
    }
}
