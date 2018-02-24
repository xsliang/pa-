//あなたは拾った古いパソコンで画像を表示するため、
//グレースケールの画像を白黒の二値画像に変換する事にしました。

//グレースケールの画像では 255 (白) から 0 (黒) の 256 階調で画像を表現します。
//0 に近いほど黒色に, 255 に近いほど白色に近い色になります。
//二値画像では単純に 1 (白) から 0 (黒) の 2 階調で表現します。
//このため、グレーな画素値を白か黒にする必要があります。 (画素とは画像の最小単位の点を表します)

//今回は単に表示するだけなので、単純に以下の条件を用いて二値画像に変換します。

//・画素値が 128 以上 : 1 (白)
//・画素値が 127 以下 : 0 (黒)

//この変換を図で示すと以下のようになります。


//入力で画像のサイズとそれぞれの画素値が渡されるので、
//与えられた条件で二値化した結果を出力して下さい。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C030
    {
        public static void Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int H = Convert.ToInt32(line.Split(' ')[0]);
                int W = Convert.ToInt32(line.Split(' ')[1]);
                if (H < 1 || H > 400 || W < 1 || W > 400)
                {
                    return;
                }

                List<string> result = new List<string>();

                for (int i = 0; i < H; i++)
                {
                    var dataLine = System.Console.ReadLine();

                    string[] aryLine = dataLine.Split(' ');

                    string[] aryResult = new string[W];

                    for (int j = 0; j < W; j++)
                    {
                        int intNum = Convert.ToInt32(aryLine[j]);
                        if (intNum < 0 || intNum > 255)
                        {
                            return;
                        }

                        if (intNum >= 128)
                        {
                            aryResult[j] = "1";
                        }
                        else if (intNum <= 127)
                        {
                            aryResult[j] = "0";
                        }
                    }

                    result.Add(string.Join(" ", aryResult));
                }

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            catch
            {

            }
        }
    }
}
