//野球の各打者はストライクが 3 つたまるとアウトとなり、ボールが 4 つたまるとフォアボールとなります。アウトあるいはフォアボールになるとこの打者の番は終了します。

//あなたはストライクとボールを判定してコールする審判です。その場の状況に合わせて適切なコールを出しましょう。


//・ストライクが 1 〜 2 つたまったとき → "strike!"
//・ストライクが 3 つたまったとき → "out!"
//・ボールが 1 〜 3 つたまったとき → "ball!"
//・ボールが 4 つたまったとき → "fourball!"

//ある打者の番における投球の結果(ストライクまたはボール) が与えられるので、各投球に対してどのようなコールをすればよいかを出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C033
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N < 3 || N > 6)
            {
                return;
            }

            List<string> input = new List<string>();

            for (int i = 0; i < N; i++)
            {
                line = System.Console.ReadLine();
                input.Add(line);
            }

            int countBall = 0;
            int countStrike = 0;

            foreach (var item in input)
            {
                if (item == "ball")
                {
                    countBall++;
                    if (countBall==4)
                    {
                        Console.WriteLine("fourball!");
                    }
                    else
                    {
                        Console.WriteLine("ball!");
                    }          
                }
                else if (item == "strike")
                {
                    countStrike++;
                    if (countStrike==3)
                    {
                        Console.WriteLine("out!");
                    }
                    else
                    {
                        Console.WriteLine("strike!");
                    }
                }
            }
        }
    }
}
