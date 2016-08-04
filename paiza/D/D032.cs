// D032:充電時間

//1 分間で 1 % の充電が可能なスマートフォンの充電器があります。
//現在のスマートフォンのバッテリーの残量 n % からこの充電器で 100 % まで充電するのに何分かかるかを求めてください。


//例)
//現在のバッテリー残量: 30 % → 充電にかかる時間: 70 分
//現在のバッテリー残量: 15 % → 充電にかかる時間: 85 分

using System;
public class D032
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 0 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            System.Console.WriteLine(100 - n);
        }
    }
}
