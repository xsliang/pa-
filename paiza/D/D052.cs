//あなたのクラスでは、運動会の出し物で人間ピラミッドをやることになりました。ある段数のピラミッドを組むのに必要な人数を求めるプログラムをつくりましょう。

//ピラミッドでは以下のように上から i 段目には i 人が必要となります。

//例)

//ピラミッドの段数: 5 段
//1 + 2 + 3 + 4 + 5 = 15
//→ 必要な人数: 15 人 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D052
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(line);
                if (1 <= n && n <= 100)
                {
                    System.Console.WriteLine((1 + n) * n / 2);
                }
            }
            catch
            {

            }

        }
    }

}
