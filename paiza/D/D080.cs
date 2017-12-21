//あなたは忘年会の幹事を任されました。
//お店を予約しようと考えましたが、お酒を飲まない人がおり、お酒飲み放題をつけなくていい人が居ることに気が付きました。

//お酒飲み放題がある場合は 6000 円、お酒飲み放題がない場合は 4000円のお店において
//お酒飲み放題をつける人数が n 人、お酒飲み放題をつけない人数が m 人
//それぞれ与えられるので合計が何円かを出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D080
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！

            var line = System.Console.ReadLine();

            int n = Convert.ToInt32(line.Split(' ')[0]);
            int m = Convert.ToInt32(line.Split(' ')[1]);
            if (n < 1 || n > 100 || m < 1 || m > 100)
            {
                return;
            }



            System.Console.WriteLine(n * 6000 + (m * 4000));
        }
    }
}
