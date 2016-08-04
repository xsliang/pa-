// D027:nまでの和

//ある 2 以上の整数 n が与えられます。

//1　から n までの 1 ずつ増加する数列の和を出力してください。

//例えば以下のような入力の場合

//    10

//数列は以下のようになり

//    1, 2, 3, 4, 5, 6, 7, 8, 9, 10

//以下のように出力して下さい

//    55

using System;
public class D027
{
    public static void Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 2 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            System.Console.WriteLine((1 + n) * n / 2);
        }
    }
}

