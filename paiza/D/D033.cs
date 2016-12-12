// D033:頭文字

//あなたは半角アルファベットの苗字と名前からそれぞれ 1文字目を取りイニシャルを作ることにしました。
//半角スペース区切りで苗字と名前が入力されるので、1文字目を取り "." (半角ドット)で区切った文字列を出力してください。

//例えば以下の様な入力の場合

//    Paiza Tarou

//以下の様に出力してください

//    P.T

using System;
public class D033
{
    public static void Main()
    {
        var line = System.Console.ReadLine();
        var ary = line.Split(' ');
        if (ary[0].Length >= 2 && ary[0].Length <= 20 &&
        ary[1].Length >= 2 && ary[1].Length <= 20)
        {
            string test1 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string test2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char item in ary[0])
            {
                if (test1.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            if (test2.Contains(ary[0][0].ToString()) == false)
            {
                return;
            }
            foreach (char item in ary[1])
            {
                if (test1.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            if (test2.Contains(ary[1][0].ToString()) == false)
            {
                return;
            }
            System.Console.WriteLine(ary[0][0].ToString() + "." + ary[1][0].ToString());
        }
    }
}
