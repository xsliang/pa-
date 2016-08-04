// D036:アットマーク

//半角小文字アルファベットで構成された文字列 S が入力されます。

//文字列 S の中に含まれる "at" という文字列を全て "@" (アットマークに)置換して出力して下さい。

//例えば

//    paizaatcodeattest

//と入力された場合

//    paiza@code @test

//と出力してください。

public class D036
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (line.Length >= 1 && line.Length <= 100)
        {
            line = line.Replace("at", "@");
            System.Console.WriteLine(line);
        }
    }
}