//今日は杯座神社に初詣でにやってきました。この神社の参拝の仕方は特殊で、参拝時の「礼」と「拍手」の回数が時と場合によって変わります。規則がよくわからないあなたは前の人のやり方をみて真似することにしました。

//前の人の参拝の「L 礼 M 拍手 N 礼」 について L, M, N が与えられるので、「礼」を "A"、「拍手」を "B"　として参拝の動作を表す文字列を出力してください。

//例)

//前の人の参拝: 2 2 1

//→ AABBA

//前の人の参拝: 3 3 7

//→ AAABBBAAAAAAA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D058
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                int l = Convert.ToInt32(line.Split(' ')[0]);
                int m = Convert.ToInt32(line.Split(' ')[1]);
                int n = Convert.ToInt32(line.Split(' ')[2]);
                if (0 <= l && l <= 20 &&
                0 <= m && m <= 20 &&
                0 <= n && n <= 20)
                {
                    string result = "";
                    for (int i = 0; i < l; i++)
                    {
                        result = result + "A";
                    }
                    for (int i = 0; i < m; i++)
                    {
                        result = result + "B";
                    }
                    for (int i = 0; i < n; i++)
                    {
                        result = result + "A";
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
