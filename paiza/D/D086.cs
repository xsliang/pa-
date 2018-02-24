//あなたはお正月に向けて門松を作ることにしました。 門松は3本の竹からなり、それぞれ竹の長さは 3 : 5 : 7 の比率で作る習わしとなっています。

//最も短い竹の長さが与えられるので、 3 本の竹に切断し門松を作るために必要な 1 本の竹の長さを出力してください。この時切断面は竹に対して垂直に切られるものとします。

//入力例1 では最も短い竹の長さが 60 と以下のように与えられます。

//    60

//以下の図のように最も短い竹 3 に対し全体は 15 となるので最も短い竹の 5 倍が全体の竹の長さとなります。

//図1

//よって以下のように出力します。

//    300

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D086
    {
        public static void Main()
        {
            var line = System.Console.ReadLine();
            double count = Convert.ToDouble(line);
            if (count < 1 || count > 100)
            {
                return;
            }

            System.Console.WriteLine(count / 3.0 * 15);
        }
    }
}
