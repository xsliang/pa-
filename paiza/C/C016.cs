// C016:Leet文字列

//Leet と呼ばれるインターネットスラングがあります。
//Leet ではいくつかのアルファベットをよく似た形の他の文字に置き換えて表記します。 Leet の置き換え規則はたくさんありますが、ここでは次の置き換え規則のみを考えましょう。
//置き換え前 置き換え後
//A 	4
//E 	3
//G 	6
//I 	1
//O 	0
//S 	5
//Z 	2
//文字列が入力されるので、これを Leet に変換して出力するプログラムを書いてください。

public class C016
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        string test = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (line.Length >= 1 && line.Length <= 100)
        {
            foreach (char item in line)
            {
                if (test.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            line = line.Replace("A", "4");
            line = line.Replace("E", "3");
            line = line.Replace("G", "6");
            line = line.Replace("I", "1");
            line = line.Replace("O", "0");
            line = line.Replace("S", "5");
            line = line.Replace("Z", "2");
            System.Console.WriteLine(line);
        }
    }
}

