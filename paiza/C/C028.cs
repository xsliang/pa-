//英単語のテストの採点ではどこまでをスペルミスとみなしてどこまでを別の単語とみなすかが悩みどころです。
//そこで paiza 予備校では以下の様な採点基準を導入してこれに従って厳密に採点することにしています。

//・正解の単語と完全一致→ ◯ 2 点
//・正解の単語と長さ(文字数)が異なる→ × 0 点
//・正解の単語と長さは同じだが 1 文字だけ異なる→ △ 1 点
//・正解の単語と長さは同じだが 2 文字以上異なる→ × 0 点

//ここで「文字が異なる」とは、同じ位置にある文字が異なるということを意味しています。

//例)
//正解: apple, 解答: aple → 0 点(長さが異なる)
//正解: orange, 解答: olange → 1 点(長さは同じだが 1 文字だけ異なる)
//正解: grape, 解答: glepe → 0 点(長さは同じだが 2 文字異なる)
//正解: lemon, 解答: lemon → 2 点(完全一致)

//合計得点 → 3 点

//問題数と各問題の正解の単語および生徒の解答が与えられるので、このような形で paiza 予備校の採点基準に従いこの生徒の合計得点を算出してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C028
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N < 1 || N > 1000)
                {
                    return;
                }
                int count = 0;
                for (int i = 0; i < N; i++)
                {
                    line = System.Console.ReadLine();
                    string q = line.Split(' ')[0];
                    string a = line.Split(' ')[1];
                    if (q.Length < 1 || q.Length > 20 || a.Length < 1 || a.Length > 20)
                    {
                        return;
                    }
                    if (q.Length != a.Length)
                    {
                        continue;
                    }
                    else
                    {
                        if (q == a)
                        {
                            count = count + 2;
                        }
                        else
                        {
                            int temp = 0;
                            for (int j = 0; j < q.Length; j++)
                            {
                                if (q[j] != a[j])
                                {
                                    temp++;
                                }
                            }
                            if (temp == 1)
                            {
                                count++;
                            }
                        }
                    }
                }
                System.Console.WriteLine(count);

            }
            catch
            {
            }
        }
    }
}
