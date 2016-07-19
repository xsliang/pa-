// D045:通知票

//paiza 中学校ではこれまで 5 ~ 1 の数字で成績をつけていましたが、英語教育に力を入れるため今年度から A ~E のアルファベットで成績をつけることにしました。
//すでに成績を数字でつけてしまったあなたはあわててアルファベットに変換することにしました。

//例)
//変換前 -> 変換後
//5 -> A
//3 -> C
//2 -> D
//4 -> B
//1 -> E 

using System;
public class D045
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 5)
        {
            switch (Convert.ToInt32(line))
            {
                case 5:
                    System.Console.WriteLine("A");
                    break;
                case 4:
                    System.Console.WriteLine("B");
                    break;
                case 3:
                    System.Console.WriteLine("C");
                    break;
                case 2:
                    System.Console.WriteLine("D");
                    break;
                case 1:
                    System.Console.WriteLine("E");
                    break;
                default:
                    break;
            }
        }
    }
}
