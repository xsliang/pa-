//バレンタインデーも終わり、あなたはホワイトデーにいくつチョコレートを用意すればよいかを計算するプログラムを作ることにしました。

//もらったチョコレートが 1 つ以上であればその 3 倍の数を、 0 個であれば自分用に 1 つだけ用意することにします......。

//例)
//もらったチョコレート: 2 個
//→ 用意するチョコレート: 2 x 3 = 6 個

//もらったチョコレート: 0 個
//→ 用意するチョコレート: 1 個

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D061
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！

            try
            {
                var line = System.Console.ReadLine();
                int c = Convert.ToInt32(line);
                if (0 <= c && c <= 100)
                {
                    int result = 0;
                    if (c == 0)
                    {
                        result = 1;
                    }
                    else
                    {
                        result = c * 3;
                    }
                    System.Console.WriteLine(result);
                }
            }
            catch
            {

            }

        }
    }

}
