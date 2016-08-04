// D043:天気の表示

//あなたは 0 % 〜 100 % 降水確率の数値を得て、その数値から天気を文字列で表示をしようと考えました。
//表示のルールは以下のよう定めました。

//・降水確率が 0 % 以上 30 % 以下ならば "sunny"
//・降水確率が 31 % 以上 70 % 以下ならば "cloudy"
//・降水確率が 71 % 以上ならば "rainy"

//降水確率 n(%) が与えられるので上のルールに従って文字列を出力して下さい。

using System;
public class D043
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        try
        {
            int n = Convert.ToInt32(line);
            if (0 <= n && n <= 100)
            {
                if (0 <= n && n <= 30)
                {
                    System.Console.WriteLine("sunny");
                }
                else if (n >= 31 && n <= 70)
                {
                    System.Console.WriteLine("cloudy");
                }
                else if (n >= 71)
                {
                    System.Console.WriteLine("rainy");
                }
            }
        }
        catch
        { }
    }
}
