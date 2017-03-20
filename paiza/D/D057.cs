//クリスマスが今年もやってきます！子どもにプレゼントを選んであげましょう。あなたはプレゼントの候補を 3 つにしぼり、子どもの通知表の成績に応じてプレゼントを決めることにしました。

//成績が 3 (最高) であれば候補の中で最も高価なものを、2 であれば 2 番目に高価なものを、1 であれば最も安価なものをあげます。

//子どもの成績とプレゼント候補からあげるプレゼントを決定するプログラムを作成してください。

//例)

//成績: 3

//プレゼント候補(値段の安い順): 車のおもちゃ、プラモデル、ゲーム機

//→ あげるプレゼント: ゲーム機

//成績: 2

//プレゼント候補(値段の安い順): 手袋、マフラー、セーター

//→ あげるプレゼント: マフラー

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D057
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            var line2 = System.Console.ReadLine();
            try
            {
                int g = Convert.ToInt32(line);
                if (1 <= g && g <= 3)
                {
                    string[] words = line2.Split(' ');
                    if (words[g - 1].Length >= 1 && words[g - 1].Length <= 20)
                    {
                        Console.WriteLine(words[g - 1]);
                    }
                }

            }
            catch
            {

            }

        }
    }

}
