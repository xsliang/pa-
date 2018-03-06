//何やら子供たちが集まって背比べをしています。話を聞いてみると、一人の子供をのぞいて他の子供の身長は正確にわかっており、その一人の子供の身長を他の子どもと比べることで測ろうとしているようです。手助けをしてあげましょう。

//例)

//図1

//ここでは 6 人の子供の身長がわかっており、この子供たちともう一人の子供の身長を比較すると上のようになりました。これらの結果をまとめると身長のわかっていない子供の身長は 116.9cm 以上 117.6cm 以下であることがわかります(入力例 1)。

//他の同じような状況の子供たちのためにもこれを自動化するプログラムをつくりましょう。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C040
    {
        static void Main(string[] args)
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N < 2 || N > 100)
            {
                return;
            }

            decimal ge = 0;
            decimal le = 0;

            for (int i = 0; i < N; i++)
            {
                line = System.Console.ReadLine();
                string c = line.Split(' ')[0];
                decimal temp = Convert.ToDecimal(line.Split(' ')[1]);

                if (temp < 100 || temp > 200)
                {
                    return;
                }

                if (c == "ge")
                {
                    if (ge == 0)
                    {
                        ge = temp;
                    }
                    else if (ge < temp)
                    {
                        ge = temp;
                    }
                }
                else if (c == "le")
                {
                    if (le == 0)
                    {
                        le = temp;
                    }
                    else if (le > temp)
                    {
                        le = temp;
                    }
                }
                else
                {
                    return;
                }
            }

            Console.WriteLine(ge + " " + le);
        }
    }
}
