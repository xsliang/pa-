// C014:ボールが入る箱

//半径r のお気に入りのボールを手に入れたあなたは、それを収納することができる箱を探しています。

//今、n 個の箱があり、i(1 ≦ i ≦ n) 番目の箱は高さh_i、幅w_i、奥行きd_i です。各箱においてボールの直径が、箱の高さ、幅、奥行きの3つの長さのうち最も短いもの以下であれば、無事にボールを収納することができます。

//ボールの半径と箱の情報が与えられるので、ボールを収納することができる箱の番号を昇順にすべて答えてください。

//        n r　　　#箱の数n, ボールの半径r 表す整数
//    h_1 w_1 d_1　　　#1個目の箱の高さ、幅、奥行きを表す整数
//    h_2 w_2 d_2　　　#2個目の箱の高さ、幅、奥行きを表す整数
//    ...
//    h_n w_n d_n　　　#n個目の箱の高さ、幅、奥行きを表す整数

//すべてのテストケースで以下の条件を満たします。

//・ 1 ≦ n ≦ 100
//・ 1 ≦ r ≦ 100
//・ 1 ≦ h_i, w_i, d_i ≦ 200

//少なくとも1つはボールを収納できる箱が存在します

using System;
public class C014
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        try
        {
            var lineNR = System.Console.ReadLine();
            if (Convert.ToInt32(lineNR.Split(' ')[0]) >= 1 && Convert.ToInt32(lineNR.Split(' ')[0]) <= 100 &&
            Convert.ToInt32(lineNR.Split(' ')[1]) >= 1 && Convert.ToInt32(lineNR.Split(' ')[1]) <= 100)
            {
                int n = Convert.ToInt32(lineNR.Split(' ')[0]);
                int r = Convert.ToInt32(lineNR.Split(' ')[1]);
                for (int i = 0; i < n; i++)
                {
                    var linehwd = System.Console.ReadLine();
                    if (Convert.ToInt32(linehwd.Split(' ')[0]) >= 1 && Convert.ToInt32(linehwd.Split(' ')[0]) <= 200 &&
                    Convert.ToInt32(linehwd.Split(' ')[1]) >= 1 && Convert.ToInt32(linehwd.Split(' ')[1]) <= 200 &&
                    Convert.ToInt32(linehwd.Split(' ')[2]) >= 1 && Convert.ToInt32(linehwd.Split(' ')[2]) <= 200)
                    {
                        int h = Convert.ToInt32(linehwd.Split(' ')[0]);
                        int w = Convert.ToInt32(linehwd.Split(' ')[1]);
                        int d = Convert.ToInt32(linehwd.Split(' ')[2]);
                        if (h >= r * 2 && w >= r * 2 && d >= r * 2)
                        {
                            System.Console.WriteLine(i + 1);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        catch
        { }
    }
}