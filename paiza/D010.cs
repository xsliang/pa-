// D010:Eメールアドレス

//Eメールアドレスはローカル部とドメインを「@」を繋いだ文字列で表されます。

//ローカル部を s, ドメインを t として、それぞれ長さ n の文字列が改行区切りで入力されます。

//以下の構文に沿った文字列を出力してください。

//    s(ローカル部)@t(ドメイン)


//例えば

//    info
//    paiza.jp

//のような入力の場合

//    info @paiza.jp

//と出力して下さい。

public class D010
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var s = System.Console.ReadLine();
        var t = System.Console.ReadLine();
        if (s.Length >= 1 && s.Length <= 64 && t.Length >= 1 && t.Length <= 64)
        {
            string test = "1234567890.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char item in s)
            {
                if (test.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            foreach (char item in t)
            {
                if (test.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            System.Console.WriteLine(s + "@" + t);
        }
    }
}
