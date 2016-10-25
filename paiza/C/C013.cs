// C013:嫌いな数字

//あなたは運悪く病気にかかってしまい入院しなくてはいけなくなりました。しかし、嫌いな数字があり、その数字が含まれる部屋番号の病室に入ると治療がうまく行かないのでは無いかと不安になってしまいます…。

//そこで、部屋番号のどの桁にも嫌いな数字が含まれていない病室をリストアップして入院先に伝えることにしました。

//・1行目に嫌いな数字 n(0から9までの1桁の数字)
//・2行目に病室の総数 m
//・3行目以降に各病室の部屋番号を表す整数 r_i(1 <= i <= m)

//が改行区切りで与えられるので、希望する病室の部屋番号をすべて改行区切りで出力して下さい。

//もし、希望する病室が1つもない場合は"none" と出力して下さい。

//n #嫌いな数字
//    m #病室の総数
//    r_1 #1個目の部屋番号
//    r_2 #2個目の部屋番号
//    ...
//    r_m #m個目の部屋番号

//すべてのテストケースで以下の条件を満たします。

//n, m, r_iはそれぞれ整数です。

//0 ≦ n ≦ 9
//1 ≦ m ≦ 100
//1 ≦ r_i ≦ 1000

using System;
using System.Collections.Generic;
public class C013
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        try
        {
            var line1 = System.Console.ReadLine();
            if (Convert.ToInt32(line1) >= 0 && Convert.ToInt32(line1) <= 9)
            {
                int m = Convert.ToInt32(line1);
                var line2 = System.Console.ReadLine();
                if (Convert.ToInt32(line2) >= 1 && Convert.ToInt32(line1) <= 100)
                {
                    int n = Convert.ToInt32(line2);
                    List<string> r = new List<string>();
                    for (int i = 0; i < n; i++)
                    {
                        var line3 = System.Console.ReadLine();
                        if (Convert.ToInt32(line3) >= 1 && Convert.ToInt32(line3) <= 1000)
                        {
                            if (line3.ToString().Contains(m.ToString()))
                            {

                            }
                            else
                            {
                                r.Add(line3);
                            }
                        }
                    }
                    if (r.Count == 0)
                    {
                        System.Console.WriteLine("none");
                    }
                    else
                    {
                        foreach (string temp in r)
                        {
                            System.Console.WriteLine(temp);
                        }
                    }
                }

            }
        }
        catch
        {

        }
    }
}
