//今日は PAIZA 6 というくじの当選番号の公表日です。

//PAIZA 6 の購入者は 1 から 100 までの好きな数字を 6 つ選びます。
//抽選では同様に 6 つの当選番号が発表され、購入したくじの数字と一致していた数字の数に応じて賞金が当たります。

//あなたは、先日 N 枚のくじを購入しました。
//プログラマーであるあなたは、N 枚の宝くじそれぞれについて、 当選番号と一致した数字の数について調べるプログラムを書くことにしました。

//ここで、くじの購入例を見てみましょう。

//すべてのテストケースで以下の条件を満たします。

//・1 ≦ N ≦ 100
//・1 ≦ a_i, b_i, c_i, d_i, e_i, f_i ≦ 100

//a_i, b_i, c_i, d_i, e_i, f_i(0 ≦ i ≦ n) は全て異なる整数

using System;
using System.Collections.Generic;
public class C023
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！

        try
        {
            var line0 = System.Console.ReadLine();
            var line1 = System.Console.ReadLine();
            int n = Convert.ToInt32(line1);

            List<string> line1List = new List<string>();
            string[] aryline1 = line0.Split(' ');
            int count = aryline1.Length;

            if (1 <= n && n <= 100)
            {
                for (int i = 0; i < n; i++)
                {
                    var line2 = System.Console.ReadLine();
                    string[] line2List = line2.Split(' ');
                    if (line2List.Length == count)
                    {
                        int result = 0;
                        foreach (string item in line2List)
                        {
                            int itemNum = Convert.ToInt32(item);

                            if (1 <= itemNum && itemNum <= 100 &&
                            Array.IndexOf(aryline1, item) != -1)
                            {
                                result++;
                            }
                        }
                        line1List.Add(result.ToString());
                    }
                }
                foreach (string item in line1List)
                {
                    System.Console.WriteLine(item);
                }
            }

        }
        catch
        {


        }

    }
}
