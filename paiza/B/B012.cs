//クレジットカード番号は16桁の番号で表すことができますが、この番号は以下の性質を持っています。

//一番右の桁を1桁目として、

//・偶数桁の数字をそれぞれ2倍し総和をとったものをeven
//（ただし、2倍したあと2桁の数字になるものは、1の位と10の位の数を足して1桁の数字にしたあと、総和をとる）
//・奇数桁の数字の総和をとったものをodd
//とすると、even + odd は10 で必ず割り切れます。

//1桁目がX と書かれた16桁の番号が複数与えられるので、それぞれに対し、上記性質をみたすようにX に入る数字を求めてください。

//すべてのテストケースで以下の条件を満たします。

//1 ≦ n ≦ 100
//a_i(1 ≦ i ≦ n) は長さ16の文字列です。
//1文字目から15文字目は0から9までのいずれかの数字が書かれており、16文字目はX(アルファベット大文字のエックス) が書かれています。

using System;
using System.Collections.Generic;
public class B012
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var lineCount = System.Console.ReadLine();
        string number = "0123456789";
        List<string> lstData = new List<string>();
        List<int> resultData = new List<int>();
        try
        {
            if (Convert.ToInt32(lineCount) >= 1 && Convert.ToInt32(lineCount) <= 100)
            {
                //input
                int count = Convert.ToInt32(lineCount);
                for (int i = 0; i < count; i++)
                {
                    var dataInput = System.Console.ReadLine();
                    string data = dataInput.ToString();
                    if (data.Length != 16 && data[15] != 'X')
                    {
                        return;
                    }
                    else
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            if (number.Contains(data[j].ToString()) == false)
                            {
                                return;
                            }
                        }

                        lstData.Add(data);
                    }
                }

                //compute
                for (int i = 0; i < count; i++)
                {
                    string data = lstData[i];
                    //even
                    int even = 0;
                    for (int a = 0; a < 15; a = a + 2)
                    {
                        int temp1 = Convert.ToInt32(data[a].ToString()) * 2;
                        if (temp1 < 10)
                        {
                            even = even + temp1;
                        }
                        else
                        {
                            even = even + 1 + (temp1 - 10);
                        }
                    }

                    //odd
                    int odd = 0;
                    for (int a = 1; a < 15; a = a + 2)
                    {
                        int temp1 = Convert.ToInt32(data[a].ToString());
                        odd = odd + temp1;
                    }

                    int addresult = even + odd;
                    for (int b = 0; b < 10; b++)
                    {
                        if ((addresult + b) % 10 == 0)
                        {
                            resultData.Add(b);
                            break;
                        }
                    }

                }

                //result
                for (int i = 0; i < count; i++)
                {
                    System.Console.WriteLine(resultData[i].ToString());
                }
            }
        }
        catch
        {

        }
    }
}