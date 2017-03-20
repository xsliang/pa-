//そろそろ衣替えのシーズンです。夏物の服をしまって冬物の服を出しましょう。

//10 着の服に関してそれが夏物か冬物かの情報が与えられるので、その半分(5 着) 以上が冬物になっているかどうか(なっていれば OK、なっていなければ NG) を判定してください。

//例)

//夏物: S、冬物: W

//W W W W W S W W S W

//→ W 8 (≧ 5) 個 → OK

//W W S S S W S W S S

//→ W 4 (< 5) 個 → NG

public class D051
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        string[] aryline = line.ToString().Split(' ');
        if (aryline.Length > 0 && aryline.Length <= 10)
        {
            int count = 0;
            foreach (string item in aryline)
            {
                if (item == "W")
                {
                    count++;
                }

            }
            if (count >= 5)
            {
                System.Console.WriteLine("OK");
            }
            else
            {
                System.Console.WriteLine("NG");
            }
        }
    }
}
