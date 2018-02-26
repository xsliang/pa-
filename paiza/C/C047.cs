//あなたは霧島京子たちが通うパイザ女学院の用務員として、校舎に備え付けのエレベーターを管理しています。
//エレベーターが一定の距離を動くと、定期点検をしなければなりません。
//エレベーターの動きのログをもとに、エレベーターが何階分の距離を動いたか計算するプログラムを完成させてください。
//ただし、エレベーターは最初は必ず 1 階にいるものとします。

//以下は入力例 1 を図で表したものです。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C047
    {
        public static void Main()
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N < 0 || N > 100)
            {
                return;
            }

            int count = 0;
            int first = 1;
            for (int i = 0; i < N; i++)
            {
                line = System.Console.ReadLine();
                int f = Convert.ToInt32(line);
                if (f < 0 || f > 100)
                {
                    return;
                }

                count = count + (Math.Abs(f - first));
                first = f;
            }

            Console.WriteLine(count);
        }
    }
}
