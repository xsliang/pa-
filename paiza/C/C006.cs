// C006:ハイスコアランキング

//あなたはとあるアイテム集めゲームのユーザーランキングを作ることになりました。

//アイテムの種類はN個あり、アイテムは種類ごとに得点が異なります。
//各アイテム種別毎の1個あたりの得点はCiで表現され、ユーザーが持っている
//それぞれのアイテムの数はXiで表現されます。
//（アイテムiの１個当たりの得点はCi、ユーザーの持ち数はXiという事です）

//ユーザーのスコアは、各アイテム持ち数×各アイテムの得点の総和となります。

//例）
//　アイテム種別毎の得点
//C1 = 1.5, C2 = 1.2, C3 = 2, C4 = 0.4


//ユーザーのアイテム持ち数
//X1 = 49, X2 = 30, X3 = 2, X4 = 6486


//上記の場合スコアS
//S = C1 * X1 + C2 * X2 + C3 * X3 + C4 * X4
//= 49 * 1.5 + 1.2 * 30 + 2 * 2 + 0.4 * 6486
//= 2707.9
//　　　≒ 2708
//　として算出します。

//Sの値が小数になった場合は、小数第一位を四捨五入し、整数に
//します。以上のスコア計算を、M人のユーザーに行い、トップKのスコア(Ｋ＝３の場合トップ３)を
//出力してください。

using System;
using System.Collections.Generic;

public class C006
{
    public static void Main()
    {
        try
        {
            var line1 = System.Console.ReadLine();
            if (1 <= Convert.ToInt32(line1.Split(' ')[0]) && Convert.ToInt32(line1.Split(' ')[0]) <= 100 &&
            1 <= Convert.ToInt32(line1.Split(' ')[1]) && Convert.ToInt32(line1.Split(' ')[1]) <= 1000 &&
            1 <= Convert.ToInt32(line1.Split(' ')[2]) && Convert.ToInt32(line1.Split(' ')[2]) <= Convert.ToInt32(line1.Split(' ')[1]))
            {
                int N = Convert.ToInt32(line1.Split(' ')[0]);
                int M = Convert.ToInt32(line1.Split(' ')[1]);
                int K = Convert.ToInt32(line1.Split(' ')[2]);
                var line2 = System.Console.ReadLine();
                if (line2.Split(' ').Length != N)
                {
                    return;
                }
                List<double> C = new List<double>();
                for (int i = 0; i < line2.Split(' ').Length; i++)
                {
                    if (Convert.ToDouble(line2.Split(' ')[i]) >= 0 && Convert.ToDouble(line2.Split(' ')[i]) <= 100)
                    {
                        C.Add(Convert.ToDouble(line2.Split(' ')[i]));
                    }
                    else
                    {
                        return;
                    }
                }
                List<string> listX = new List<string>();
                for (int i = 0; i < M; i++)
                {
                    var lineX = System.Console.ReadLine();
                    if (lineX.Split(' ').Length != N)
                    {
                        return;
                    }
                    for (int j = 0; j < N; j++)
                    {
                        if (Convert.ToInt32(lineX.Split(' ')[j]) >= 0 && Convert.ToInt32(lineX.Split(' ')[j]) <= 100000)
                        {

                        }
                        else
                        {
                            return;
                        }
                    }
                    listX.Add(lineX);
                }
                List<int> result = new List<int>();
                for (int i = 0; i < listX.Count; i++)
                {
                    string temp1 = listX[i];
                    double temp2 = 0;
                    for (int j = 0; j < N; j++)
                    {
                        temp2 = temp2 + Convert.ToDouble(temp1.Split(' ')[j]) * C[j];
                    }     
                    result.Add(Convert.ToInt32(Math.Round(temp2, MidpointRounding.AwayFromZero)));
                }
                result.Sort();

                for (int i = 0; i < K; i++)
                {
                    System.Console.WriteLine(result[result.Count - i - 1]);
                }
            }
        }
        catch
        {

        }

    }
}
