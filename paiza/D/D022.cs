// D022:表面積の計算

//正六面体の辺の長さ a が入力されるので表面積を出力して下さい。

//辺の長さ a の正六面体の表面積は以下の式で求められます。

using System;
public class D022
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 20)
        {
            int n = Convert.ToInt32(line);
            System.Console.WriteLine(6 * n * n);
        }
    }
}
