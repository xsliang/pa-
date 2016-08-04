// D025:数字の出力

//ある正の整数 n が入力されます。

//n を 0埋め3桁 で出力してください。
//0埋め3桁 とは2桁以下の数字の場合、左側に0を加えて3桁にすることを言います。

//例えば以下のような入力の場合

//    98

//以下のように出力して下さい

//    098

using System;
public class D025
{
    public static void Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            if (line.Length == 1)
            {
                line = "00" + line;
            }
            else if (line.Length == 2)
            {
                line = "0" + line;
            }
            System.Console.WriteLine(line);
        }
    }
}
