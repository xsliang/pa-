// D028:数字の桁数

//ある10進数の正の整数 n が与えられます。

//n が何桁かを数字で出力してください。

using System;
public class D028
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 10000)
        {
            int n = Convert.ToInt32(line);
            System.Console.WriteLine(n.ToString().Length);
        }

    }
}
