//はじめましてのあいさつをしましょう。

//名前が文字列 s1 で、性別が文字列 s2(男性は "M", 女性は "F") で与えられます。
//これに対し、男性なら "Hi, Mr. 〇〇(名前)" と、女性なら "Hi, Ms. 〇〇(名前)" と返してください。

public class D044
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        try
        {
            string s1 = line.ToString().Split(' ')[0];
            string s2 = line.ToString().Split(' ')[1];
            if (s1.Length >= 1 && s1.Length <= 100 &&
            s2 == "M" || s2 == "F")
            {
                if (s2 == "M")
                {
                    System.Console.WriteLine("Hi, Mr. " + s1);
                }
                else
                {
                    System.Console.WriteLine("Hi, Ms. " + s1);
                }
            }
        }
        catch
        {

        }
    }
}
