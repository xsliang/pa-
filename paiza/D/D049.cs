//あなたは、「わたしの秋は◯◯の秋」というアンケートの集計を任されました。

//アンケートの回答はまちまちで、「◯◯の秋」と書く人もいれば「◯◯」の部分だけ書く人もいます。これでは不便なのでまず「◯◯」の部分だけを取り出すプログラムを作りましょう。

//例)
//回答が "syokuyokunoaki" → "syokuyoku" を取り出す
//回答が "sports" → "sports" のまま

//    ・S は英字小文字からなる文字列
//・S に "noaki" という文字列は 2 つ以上含まれず、含まれる場合必ず末尾に含まれる。
//・1 ≦ (S の長さ) ≦ 20

public class D049
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (line.ToString().Length >= 1 && line.ToString().Length <= 20)
        {
            string result = line.ToString().Replace("noaki", "");
            if (line.ToString().Length - result.Length == 5 &&
            line.ToString().Substring(0, line.ToString().Length - 5) == result)
            {
                System.Console.WriteLine(result);
            }
            else
            {
                System.Console.WriteLine(line.ToString());
            }
        }
    }
}