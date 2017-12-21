
//あなたは箱に入ったお菓子を家族 N 人で分けることにしました。

//箱には縦に H 個、横に W 個の計 H × W 個のお菓子が入っていますが、N 人で均等にお菓子を分けた場合あまりが出る事があります。

//N 人で均等にできるだけ多く分けた後のあまりのお菓子を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D081
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！

            var line = System.Console.ReadLine();
            var line2 = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N < 2 || N > 10)
            {
                return;
            }
            int H = Convert.ToInt32(line2.Split(' ')[0]);
            int W = Convert.ToInt32(line2.Split(' ')[1]);
            if (H < 1 || H > 50 || W < 1 || W > 50)
            {
                return;
            }
            System.Console.WriteLine((H * W) % N);
        }
    }
}
