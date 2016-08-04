// D031:分から秒へ

//ある正の整数 n が入力されます。

//n 分から秒へ変換するプログラムを作成して下さい。

//例えば以下の様な入力の場合

//    16

//60 を掛け算し

//    960

//と出力して下さい。

using System;
public class D031
{
    public static void Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            System.Console.WriteLine(n * 60);
        }
    }
}
