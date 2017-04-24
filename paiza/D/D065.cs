//あなたはある数字を受けてエラーの種類を分類するプログラムを作成しています。

//各エラーは3桁の数字で表されておりそれぞれ、百の位の数値で大まかな分類が決まっています。

//以下のルールで分類の名称が決められています。

//・百の位が 2 であれば ok

//・百の位が 4 であれば error

//・それ以外全ての数字は unknown

//数字が入力されるので、この3つのルールにしたがって分類の名称を出力してください。

using System;
public class D065
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        try
        {
            if (line.Length == 3)
            {
                int number = Convert.ToInt32(line.Substring(0, 1));
                if (number == 2)
                {
                    System.Console.WriteLine("ok");
                }
                else if (number == 4)
                {
                    System.Console.WriteLine("error");
                }
                else
                {
                    System.Console.WriteLine("unknown");
                }

            }
        }
        catch
        {
        }
    }

}
