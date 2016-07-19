// D004:文字列の結合

//半角アルファベットのみで構成された長さmの文字列s_iがn行入力されます。

//以下のような形式で

//    Hello [s_1],[s_2],...[s_n]. 

//「Hello」に文字列s_iを入力された順に「,」で結合したものを半角スペースで結合し、末尾に「.」を結合した文字列を出力するプログラムを作成してください。

using System;
public class Hello
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！

        try
        {
            var n = System.Console.ReadLine();
            if (Convert.ToInt32(n) >= 1 && Convert.ToInt32(n) <= 20)
            {
                int number = Convert.ToInt32(n);
                string[] aryN = new string[number];
                for (int i = 0; i < number; i++)
                {
                    aryN[i] = System.Console.ReadLine();
                }
                System.Console.WriteLine("Hello " + string.Join(",", aryN) + ".");
            }
        }
        catch
        {

        }

    }
}

