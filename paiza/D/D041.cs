// D041:本棚選び

//あなたは新しい本棚を買おうと検討しています。そこで、既に持っている本の幅などから収まるか概算することにしました。

//持っている本の幅を合計したもの n(cm)、検討している本棚の段数 d 、本が収まる幅 e(cm)がそれぞれ半角スペース区切りで与えられます。
//概算なので本それぞれの違い1段に収まるかは考えないことにします。

//例えば、本の幅を合計したものが 400(cm)、検討している本棚の段数が 5、本が収まる幅が 85 (cm)の場合、以下の様な入力になり

//    400 5 85

//各段の幅を合計したものは 85 かける 5 で 425 (cm)となり、400 (cm)の本は収まるので以下のように出力して下さい。

//    OK



using System;
public class D041
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (line.Split(' ').Length == 3)
        {
            int n = Convert.ToInt32(line.Split(' ')[0]);
            int d = Convert.ToInt32(line.Split(' ')[1]);
            int e = Convert.ToInt32(line.Split(' ')[2]);
            if (1 <= n && n <= 500 &&
            1 <= d && d <= 10 &&
            1 <= e && e <= 500)
            {
                if (n <= d * e)
                {
                    System.Console.WriteLine("OK");
                }
                else
                {
                    System.Console.WriteLine("NG");
                }
            }
            else
            {
                System.Console.WriteLine("NG");
            }
        }
    }
}

