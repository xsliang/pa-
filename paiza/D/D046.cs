// D046:不思議なタマゴ

//持ったまま一定の距離を歩くと孵化する不思議なタマゴがあります。あなたはこのタマゴをなるべくいっぺんに孵化させようと思い、3 つをまとめて持っていくことにしました。これらをすべて孵化させるのに最低限必要な歩行距離を求めてください。

//例)
//孵化させるのに必要な歩行距離
//タマゴ 1: 1 km
//タマゴ 2: 3 km
//タマゴ 3: 5 km
//→ 最低限必要な歩行距離: 5 km(入力例 1 に対応)

using System;
public class D046
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        try
        {
            int d_1 = Convert.ToInt32(line.Split(' ')[0]);
            int d_2 = Convert.ToInt32(line.Split(' ')[1]);
            int d_3 = Convert.ToInt32(line.Split(' ')[2]);
            if (1 <= d_1 && d_1 <= 100 &&
            1 <= d_2 && d_2 <= 100 &&
            1 <= d_3 && d_3 <= 100)
            {
                int result = 0;
                result = d_1;
                if (result < d_2)
                {
                    result = d_2;
                }
                if (result < d_3)
                {
                    result = d_3;
                }
                System.Console.WriteLine(result.ToString());
            }
        }
        catch
        {

        }
    }
}
