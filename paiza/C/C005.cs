// C005:アドレス調査

//あなたはあるソフトウェアの開発でIPアドレスを入力してもらう機能の一部を開発しています。
//入力は手入力で「.」と「数字」で構成された長さNの文字列が入力されます。

//入力されているIPアドレスが書式に合っているか判定して、合っていればTrue、
//違っていればFalseと標準出力で出力するプログラムを作成してください。

//判別すべきIPアドレスはIPv4で定義された範囲のIPアドレスとします。書式は以下のようになります。

//    .で区切られた10進数の4つの数で表されます。
//    数の範囲は0から255までとします。

//    例:
//    100.23.103.20
//    123.11.22.33
//    14.33.103.20
//    102.233.13.2

using System;
using System.Collections.Generic;
public class C005
{
    public static void Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            List<string> result = new List<string>();
            int m = Convert.ToInt32(line);
            for (int i = 0; i < m; i++)
            {
                var line2 = System.Console.ReadLine();
                if (line2.Split('.').Length != 4)
                {
                    result.Add("False");
                }
                else
                {
                    var temp1 = line2.Split('.');
                    if (temp1.Length < 1 || temp1.Length > 100)
                    {
                        return;
                    }
                    bool isOk = true;

                    for (int j = 0; j < 4; j++)
                    {
                        int test = 0;
                        if (int.TryParse(temp1[j], out test) == true)
                        {
                            if (Convert.ToInt32(temp1[j]) < 0 || Convert.ToInt32(temp1[j]) > 255)
                            {
                                isOk = false;
                                break;
                            }

                        }
                        else
                        {
                            isOk = false;
                            break;
                        }
                    }
                    if (isOk == true)
                    {
                        result.Add("True");
                    }
                    else
                    {
                        result.Add("False");
                    }
                }
            }
            foreach (string item in result)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
