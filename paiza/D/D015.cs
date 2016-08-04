// D015:カウントダウン

//正整数 n が入力されるので、 n から 1 まで 1 ずつカウントダウンするプログラムを作成してください。

//例えば

//    3

//と入力された場合

//    3
//    2
//    1

//と出力して下さい。

using System;
public class D015
{
    public static void Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            while (n != 0)
            {
                System.Console.WriteLine(n);
                n--;
            }
        }
    }
}

