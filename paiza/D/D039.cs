// D039:正三角形かどうか

//あなたは、3つの辺の長さが分かっている三角形が正三角形なのかを判別しようとしています。
//正三角形を判別する場合、3つの辺すべての長さが等しければ正三角形と判別できます。
//3つの辺の長さ a, b, c が改行区切りで与えられるので正三角形なら "YES", 正三角形でなければ "NO" と出力してください。

//例えば

//    10
//    10
//    10

//と与えられた場合、全ての辺が等しいので正三角形となるので

//    YES

//と出力するプログラムを作成してください。

using System;
public class D039
{
    public static void Main()
    {
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        var line3 = System.Console.ReadLine();
        try
        {
            int a = Convert.ToInt32(line1);
            int b = Convert.ToInt32(line2);
            int c = Convert.ToInt32(line3);
            if (1 <= a && a <= 100 &&
            1 <= b && b <= 100 &&
            1 <= b && b <= 100 &&
            a == b && a == c && b == c)
            {
                System.Console.WriteLine("YES");
            }
            else
            {
                System.Console.WriteLine("NO");
            }

        }
        catch
        {

        }
    }
}
