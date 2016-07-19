// D011:アルファベットで何番目

//以下のような A〜Z(半角英字大文字) の中から1文字入力されます。

//    ABCDEFGHIJKLMNOPQRSTUVWXYZ

//A を 1番目としてアルファベット順で何番目かを出力して下さい。

//例えば

//    C

//のような入力の場合

//    3

//と出力して下さい。

public class D011
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        string test = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (line.Length == 1 && test.Contains(line) == true)
        {
            System.Console.WriteLine(test.IndexOf(line) + 1);
        }
    }
}
