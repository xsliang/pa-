// D023:Aの個数

//半角アルファベットで構成された文字列 s が与えられます。

//s に含まれる半角アルファベット 「A」 の数を出力して下さい。

public class D023
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        int count = 0;
        if (line.Length >= 1 && line.Length <= 100)
        {
            string test = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char item in line)
            {
                if (test.Contains(item.ToString()) == false)
                {
                    return;
                }
                if (item == 'A')
                {
                    count++;
                }
            }
            System.Console.WriteLine(count);
        }
    }
}
