
//paiza カードは毎日のお買い物でポイントがたまるお得なポイントカードです。
//ポイントの付与基準は商品の種類によって以下のように異なります。



//ポイントは以下の手順で計算されます。

//1. 商品の種類ごとの合計購入金額を計算する。
//2. それぞれのポイント付与基準に基づき商品の種類ごとの付与ポイントを計算する。
//3. 商品の種類ごとの付与ポイントを合計する。(100円未満は切り捨て)

//買い物内訳と合計ポイントの例を見てみましょう。

//商品 1: 食料品 200 円
//商品 2: 書籍 240 円
//商品 3: 食料品 120 円
//商品 4: その他 460 円
//商品 5: 書籍 240 円
//商品 6: 衣類 3200 円

//食料品合計 320 円 → 15 ポイント
//書籍合計 480 円 → 12 ポイント
//衣類合計 3200 円 → 64 ポイント
//その他合計 460 円 → 4 ポイント => 合計ポイント → 95 ポイント
//このように購入した商品の種類と金額のリストが与えられるので、その買い物で付与されるポイントの合計を求めてください。 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C032
    {
        public static void Main()
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N < 0 || N > 1000)
            {
                return;
            }

            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;


            for (int i = 0; i < N; i++)
            {
                line = System.Console.ReadLine();
                int v = Convert.ToInt32(line.Split(' ')[0]);
                int p = Convert.ToInt32(line.Split(' ')[1]);

                if (v < 0 || v > 3)
                {
                    return;
                }

                if (p < 10 || p > 10000 || p % 10 != 0)
                {
                    return;
                }

                //if (p < 100)
                //{
                //    continue;
                //}

                // decimal temp = Math.Floor(p / 100);

                switch (v)
                {
                    case 0:
                        n1 = n1 + p;
                        break;
                    case 1:
                        n2 = n2 + p;
                        break;
                    case 2:
                        n3 = n3 + p;
                        break;
                    case 3:
                        n4 = n4 + p;
                        break;
                    default:
                        break;
                }
            }

            n1 = Convert.ToInt32(Math.Floor(n1 / 100.0) * 5);
            n2 = Convert.ToInt32(Math.Floor(n2 / 100.0) * 3);
            n3 = Convert.ToInt32(Math.Floor(n3 / 100.0) * 2);
            n4 = Convert.ToInt32(Math.Floor(n4 / 100.0) * 1);

            Console.WriteLine(n1 + n2 + n3 + n4);
        }
    }
}
