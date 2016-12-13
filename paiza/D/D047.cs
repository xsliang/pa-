// あなたは五輪のメダリスト表の作成係です。

//金・銀・銅メダリストの国名・選手名が順番に与えられるので、それぞれの国名・選手名の前に獲得メダル("Gold", "Silver", "Bronze") を記していきましょう。

//例)
//与えられる入力

//    Japan
//    Russia
//    China


//期待する出力

//    Gold Japan
//    Silver Russia
//    Bronze China

public class D047
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        var line3 = System.Console.ReadLine();
        if (line1.ToString().Length >= 1 && line1.ToString().Length <= 20 &&
        line2.ToString().Length >= 1 && line2.ToString().Length <= 20 &&
        line3.ToString().Length >= 1 && line3.ToString().Length <= 20)
        {
            System.Console.WriteLine("Gold " + line1.ToString());
            System.Console.WriteLine("Silver " + line2.ToString());
            System.Console.WriteLine("Bronze " + line3.ToString());
        }
    }
}