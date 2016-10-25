// C010:安息の地を求めて

//今日みたいな天気のよい休日は、近所の公園に行って読書をしましょう！
//早速、お気に入りの本を持って公園にやってきたあなたでしたが、不運なことに公園の一角で工事が行われているようです。
//工事現場の近くは騒音が大きいので読書に向いていません。 そこであなたは、まず読書に適した場所を探すことにしました。

//工事現場は公園にただ一つだけあり、その位置は(a, b) です。
//工事現場から距離 R メートル未満は騒音が大きいので読書には適していません。
//また、公園には読書にうってつけの木陰が N 箇所あり、i 番目の木陰の位置は(x_i, y_i) です。

//以上の情報が与えられたとき、各木陰が読書に適している(つまり、工事現場から R メートル以上離れている)かどうかを判定するプログラムを書いてください。

//「位置(x, y) が工事現場から R メートル以上離れている」という条件は以下の式で表されます。

// (x-a)^2+(y-b)^2>=R^2

//出力は N 行からなります。 N 個の木陰それぞれに対して、その木陰が読書に適している
//(つまり、工事現場から R メートル以上離れている)ならば "silent" と出力してください。
//その木陰が読書に適していないならば "noisy" と出力してください。

//最後は改行し、余計な文字、空行を含んではいけません

//すべてのテストケースで以下の条件を満たします。

//入力値はすべて整数で以下を満たします。
//0 ≦ a ≦ 100
//0 ≦ b ≦ 100
//1 ≦ R ≦ 100
//1 ≦ N ≦ 1000
//0 ≦ x_i ≦ 100
//0 ≦ y_i ≦ 100

using System;
public class C010
{
    public static void Main()
    {
        try
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var abR = System.Console.ReadLine();
            if (Convert.ToInt32(abR.Split(' ')[0]) >= 0 && Convert.ToInt32(abR.Split(' ')[0]) <= 100 &&
            Convert.ToInt32(abR.Split(' ')[1]) >= 0 && Convert.ToInt32(abR.Split(' ')[1]) <= 100 &&
            Convert.ToInt32(abR.Split(' ')[2]) >= 1 && Convert.ToInt32(abR.Split(' ')[2]) <= 100)
            {
                int a = Convert.ToInt32(abR.Split(' ')[0]);
                int b = Convert.ToInt32(abR.Split(' ')[1]);
                int R = Convert.ToInt32(abR.Split(' ')[2]);

                var lineN = System.Console.ReadLine();
                if (Convert.ToInt32(lineN) >= 1 && Convert.ToInt32(lineN) <= 1000)
                {
                    int N = Convert.ToInt32(lineN);
                    for (int i = 0; i <= N; i++)
                    {
                        var lineXY = System.Console.ReadLine();
                        if (Convert.ToInt32(lineXY.Split(' ')[0]) >= 0 && Convert.ToInt32(lineXY.Split(' ')[0]) <= 100 &&
                        Convert.ToInt32(lineXY.Split(' ')[1]) >= 0 && Convert.ToInt32(lineXY.Split(' ')[1]) <= 100)
                        {
                            int x = Convert.ToInt32(lineXY.Split(' ')[0]);
                            int y = Convert.ToInt32(lineXY.Split(' ')[1]);
                            if ((x - a) * (x - a) + (y - b) * (y - b) >= R * R)
                            {
                                System.Console.WriteLine("silent");
                            }
                            else
                            {
                                System.Console.WriteLine("noisy");
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }
        catch
        {

        }
    }
}
