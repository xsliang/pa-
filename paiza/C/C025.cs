//あなたは届いたファックスをファックス機まで取りに行く仕事を担当しています。
//しかし、 あなたのデスクからファックス機までは遠いので、 あなたはいつも取りに行く回数を最小にしています。 今日は何回紙を取りに行く必要があるのでしょうか。

//理想的には、 1 日の最後に 1 度だけ取りに行くことが理想ですが、 実際には 2つの問題があります。

//1つ目は、 届いた紙の数が多すぎて1度に全て運べないことです。
//例えば、 紙が100 枚届いているとき、 あなたが 1 回につき 30 枚まで運べる場合は 4 回、 50 枚まで運べる場合は 2 回取りに行く必要があります。
//2 つ目は、 あまりに長い時間ファックス機に届いた紙を取りに行かないと、 上司に怒られてしまうことです。
//具体的には、 x 時 y 分に届いた紙は、 x 時 59 分までに取りに行かないと怒られてしまいます。

//例えば、

//・3 時 20 分に 70 枚
//・3 時 40 分に 170 枚
//・3 時 59 分に 90 枚
//・4 時 05 分に 55 枚
//・4 時 25 分に 40 枚

//届くとし、あなたは 1 度につき 50 枚運べるとします。 この時、 3 時 59 分までに取りに行く必要のある紙の枚数は、 70 + 170 + 90 = 330 枚です。 あなたは 1 回につき 50 枚しか運べないので、 最低 7 回取りに行く必要が有ります。 4 時 59 分までに取りに行く必要のある紙の枚数は、 55 + 40 = 95 枚で、 最低 2 回取りに行く必要があります。 よって、この場合は、 7 + 2 = 9 回は紙を取りに行く必要があります。

//あなたが 1 回で運べる紙の最大枚数 M、 今日 1 日にファックスが届く回数 N、 また、その N 回それぞれについて、いつ何枚の紙が届くのかという情報が与えられます。 この情報を使って、 今日、ファックス機に何回紙を取りに行く必要があるのかを求めて下さい。

//Don't pass. I think my solution is correct.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C025
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！

            try
            {
                var line = System.Console.ReadLine();
                int M = Convert.ToInt32(line);
                if (M < 0 || M > 100)
                {
                    return;
                }
                line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N < 0 || N > 100)
                {
                    return;
                }

                double sum = 0;
                int x_temp = 0;
                double result = 0;
                for (int i = 0; i < N; i++)
                {
                    line = System.Console.ReadLine();
                    int x = Convert.ToInt32(line.Split(' ')[0]);
                    if (x > 23 || x < 1)
                    {
                        return;
                    }
                    if (x_temp == 0)
                    {
                        x_temp = x;
                    }
                    int y = Convert.ToInt32(line.Split(' ')[1]);
                    if (y > 59 || y < 1)
                    {
                        return;
                    }
                    int c = Convert.ToInt32(line.Split(' ')[2]);
                    if (x > 100 || x < 0)
                    {
                        return;
                    }

                    if (x_temp == x)
                    {
                        sum = sum + c;
                    }
                    else
                    {

                        result = result + Math.Ceiling(sum / M);
                        sum = 0;
                        sum = sum + c;
                    }


                }

                System.Console.WriteLine(Convert.ToInt32(result));
            }
            catch
            {

            }

        }

    }
}
