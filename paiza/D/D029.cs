//6面サイコロの展開図は以下のようになります。


//この図からわかるように，6面サイコロのある目とその裏側にある目（1と6，2と5，3と4）の和は必ず7になります。

//この6面サイコロの目を表す整数 n に対し，その裏側にある目を出力してください。

using System;
public class D029
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 6)
        {
            int n = Convert.ToInt32(line);
            switch (n)
            {
                case 1:
                    n = 6;
                    break;
                case 2:
                    n = 5;
                    break;
                case 3:
                    n = 4;
                    break;
                case 4:
                    n = 3;
                    break;
                case 5:
                    n = 2;
                    break;
                case 6:
                    n = 1;
                    break;
                default:
                    break;
            }
            System.Console.WriteLine(n);
        }

    }
}
