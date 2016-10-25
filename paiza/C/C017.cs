// C017:ハイアンドロー・カードゲーム

//paizaカードゲームは、複数枚の子カードそれぞれが、1枚の親カードとの強弱関係で勝負するゲームです。

//どのカードにも2つの番号が書かれています。
//1つ目の番号は1から10の整数、2つ目の番号は1から4の整数で表されます。
//また、2つの番号の各組み合わせは1枚だけカードの束に含まれています。(同じカードが2枚以上存在しません)

//2枚のカードの強弱関係は、次のルールによって決まります。
//・1つ目の番号が大きいカードのほうが強い
//・1つ目の番号が同じ場合、2つ目の番号が小さいカードのほうが強い

//親カードと子カードの情報が与えられるので、それらの強弱関係を調べるプログラムを作成してください。

//    入力は以下のフォーマットで与えられます。

//    a b
//    n
//    A_1 B_1
//    …
//    A_n B_n

//1行目では親カードの情報が与えられます。親カードの1つ目の番号は a、2つ目の番号は b で表されます。
//2行目では整数 n が与えられます。
//3行目から n 行の入力が続き、各行では、子カード i(1 ≦ i ≦ n)の情報が与えられます。
//子カード i の1つ目の番号は A_i、2つ目の番号は B_i で表されます。



//期待する出力
//    出力の i 行目では、親カードと子カード i の強弱関係を調べたときに
//    親カードの方が強いならば "High"、そうでなければ "Low" と出力してください。
//    各行では、"High" または "Low" 以外の余分な文字、空白を含んではいけません。

//    最後は改行し、余計な文字、空行を含んではいけません。

//条件
//    すべてのテストケースで以下の条件を満たします。

//    ・1 ≦ a, A_i ≦ 10
//    ・1 ≦ b, B_i ≦ 4
//    ・1 ≦ n< 40

//    ※入力データの中で同じカードが現れることはありません。

using System;
public class C017
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line.Split(' ')[0]) >= 1 && Convert.ToInt32(line.Split(' ')[0]) <= 10 &&
        Convert.ToInt32(line.Split(' ')[1]) >= 1 && Convert.ToInt32(line.Split(' ')[1]) <= 4)
        {
            var line1 = System.Console.ReadLine();
            int a = Convert.ToInt32(line.Split(' ')[0]);
            int b = Convert.ToInt32(line.Split(' ')[1]);
            if (Convert.ToInt32(line1) >= 1 && Convert.ToInt32(line1) <= 40)
            {
                int n = Convert.ToInt32(line1);
                for (int i = 0; i < n; i++)
                {
                    var line2 = System.Console.ReadLine();
                    if (Convert.ToInt32(line2.Split(' ')[0]) >= 1 && Convert.ToInt32(line2.Split(' ')[0]) <= 10 &&
                    Convert.ToInt32(line2.Split(' ')[1]) >= 1 && Convert.ToInt32(line2.Split(' ')[1]) <= 4)
                    {
                        int A = Convert.ToInt32(line2.Split(' ')[0]);
                        int B = Convert.ToInt32(line2.Split(' ')[1]);
                        if (a > A)
                        {
                            System.Console.WriteLine("High");
                        }
                        else if (a < A)
                        {
                            System.Console.WriteLine("Low");
                        }
                        else
                        {
                            if (b < B)
                            {
                                System.Console.WriteLine("High");
                            }
                            else
                            {
                                System.Console.WriteLine("Low");
                            }
                        }
                    }
                }
            }
        }

    }
}
