// D019:文字列からN番目

//半角アルファベット文字列 s と 整数 n が入力されます。

//文字列 s の1番左の文字を 1 文字目とし n 文字目のアルファベットを出力して下さい。

//例えば

//    paiza 3

//と入力された場合

//    i

//と出力して下さい。

using System;
public class D019
{
    public static void Main()
    {
        var line = System.Console.ReadLine();
        if (line.Split(' ')[0].Length >= 1 && line.Split(' ')[0].Length <= 10 &&
        Convert.ToInt32(line.Split(' ')[1]) >= 1 && Convert.ToInt32(line.Split(' ')[1]) <= line.Split(' ')[0].Length)
        {
            int n = Convert.ToInt32(line.Split(' ')[1]);
            string s = line.Split(' ')[0];
            System.Console.WriteLine(s.Substring(n - 1, 1));
        }
    }
}
