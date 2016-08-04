// D042:行列

//ある 4 つの数値を以下のような形式で並べたものを 2 次行列とよびます。

//この 2 次行列に対し、a × d - b × c を計算した値をこの 2 次行列の行列式とよびます。
//ある 2 次行列が与えられたときに、その行列式を求めるプログラムを作成してください。
//例)

//上のような行列の行列式は、1 × 4 - 3 × 2 = -2 となります(入力例1)。

using System;

public class D042
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        try
        {
            int n1 = Convert.ToInt32(line1.Split(' ')[0]);
            int n2 = Convert.ToInt32(line1.Split(' ')[1]);
            int n3 = Convert.ToInt32(line2.Split(' ')[0]);
            int n4 = Convert.ToInt32(line2.Split(' ')[1]);

            if (-1000 <= n1 && n1 <= 1000 &&
            -1000 <= n2 && n2 <= 1000 &&
            -1000 <= n3 && n3 <= 1000 &&
            -1000 <= n4 && n4 <= 1000)
            {
                int result = n1 * n4 - n2 * n3;
                System.Console.WriteLine(result.ToString());
            }
        }
        catch
        {

        }
    }
}