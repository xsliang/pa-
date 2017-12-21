//あなたはしりとりアプリを作っています。
//まず、手始めに同じ単語が出たかどうかは考慮せず 2 つの単語からしりとりをミスしたかどうかを判定する部分を作ることにしました。

//先に出た単語 A とそれに続く単語 B がそれぞれ入力されます。
//単語は必ず半角アルファベット小文字で構成された文字列です。

//また、単語 A の最後の 1 文字は "n" ではないとします。

//以下のルールを満たす時は "OK" そうでない場合は "NG" と出力するプログラムを作成してください。

//・A の最後の 1 文字が B の最初の 1 文字と一致している。
//・B の最後の 1 文字が "n" ではない。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D082
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！

            var line = System.Console.ReadLine();
            var line2 = System.Console.ReadLine();
            if (line.Length < 2 || line.Length > 20 ||
            line2.Length < 2 || line2.Length > 20)
            {
                return;
            }

            if (line[line.Length - 1] == line2[0] && line2[line2.Length - 1] != 'n')
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
