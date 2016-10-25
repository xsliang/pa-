//// C015:ポイントカードの計算

//今は月末。そろそろ今月の家計簿をつけないといけません。 あなたの手元には、とあるスーパーマーケットのレシートの山があります。

//スーパーマーケットにはポイントカードが導入されていて、買い物をするたびに購入金額に応じたポイントがたまります。 加算されるポイントは次の 3 つのルールに従って決定されます。

//1. 通常は購入金額の 1 ％（小数点以下切り捨て）とする
//2. ただし、3 のつく日は購入金額の 3 ％（小数点以下切り捨て）とする
//3. ただし、5 のつく日は購入金額の 5 ％（小数点以下切り捨て）とする

//あなたはポイントカードに、今、何ポイントたまっているのかが気になりました。 レシートの数が多いので、手で計算するのは大変です。

//早速、これを計算するプログラムを書きましょう。 ただし、今月のはじめには全くポイントがたまっておらず（0 ポイント）、また、今月中ポイントは消費されなかったものとします。



//    N　　　　#各レシートの数
//    d_1 p_1　#1枚目のレシートの日付 d_1 日, 購入金額 p_1 円
//    d_2 p_2　#2枚目のレシートの日付 d_2 日, 購入金額 p_2 円
//    ...
//    d_N p_N　#N枚目のレシートの日付 d_N 日, 購入金額 p_N 円

//1行目には今月分のレシートの枚数を表す整数 N が入力されます。続く N 行には各レシートの情報が入力されます。
//すなわち、d_i p_i は i 枚目のレシートが発行された日付が d_i 日であり、このときの購入金額が p_i 円であることを表します。

//期待する出力
//    今月末にポイントカードにたまっているポイントの値を１行に出力してください。

//    最後は改行し、余計な文字、空行を含んではいけません。

//条件
//    すべてのテストケースで以下の条件を満たします。

//    ・ 1 ≦ N ≦ 1000 (レシートの数)
//    ・ 1 ≦ d_i ≦ 31 (i番目のレシートが発行された日付)
//    ・ 1 ≦ p_i ≦ 10000 (i番目のレシートの購入金額)

using System;
public class C015
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        try
        {
            var lineN = System.Console.ReadLine();
            if (Convert.ToInt32(lineN) >= 1 && Convert.ToInt32(lineN) <= 1000)
            {
                int N = Convert.ToInt32(lineN);
                int Count = 0;
                for (int i = 1; i <= N; i++)
                {
                    var lineData = System.Console.ReadLine();
                    if (Convert.ToInt32(lineData.Split(' ')[0]) >= 1 && Convert.ToInt32(lineData.Split(' ')[0]) <= 31 &&
                        Convert.ToInt32(lineData.Split(' ')[1]) >= 1 && Convert.ToInt32(lineData.Split(' ')[1]) <= 10000)
                    {
                        int d = Convert.ToInt32(lineData.Split(' ')[0]);
                        int p = Convert.ToInt32(lineData.Split(' ')[1]);
                        if (d.ToString().Contains("3"))
                        {
                            Count = Count + (int)(p * 0.03);
                        }
                        else if (d.ToString().Contains("5"))
                        {
                            Count = Count + (int)(p * 0.05);
                        }
                        else
                        {
                            Count = Count + (int)(p * 0.01);
                        }
                    }
                }
                System.Console.WriteLine(Count);
            }
        }
        catch
        {
        }
    }
}