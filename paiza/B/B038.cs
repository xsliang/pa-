//パイザ園は個性的な動物たちを観察することができる動物園です。その中でも特に人気があるのは「パイザ鶴」と「パイザ亀」を同じ場所で飼育しているコーナーです。
//あなたはパイザ園へやって来ましたが、残念ながら今日はパイザ鶴とパイザ亀のいるコーナーにシャッターがかかっており、見ることができないようになっていました。

//そこであなたがかがんでシャッターの下からコーナーを覗いたところ、パイザ鶴とパイザ亀の足が合計で a 本見えました。また、背伸びしてシャッターの上からコーナーを覗いたところ、パイザ鶴とパイザ亀の頭が合計で b 個見えました。

//記憶によると、パイザ鶴は足が c 本生えている動物で、パイザ亀は足が d 本生えている動物です。また、どちらの動物もちょうど 1 つの頭を持ちます。コーナーにいるパイザ鶴とパイザ亀の匹数をそれぞれ推定して出力するプログラムを作成してください。


//但し、パイザ鶴とパイザ亀はどちらも最低 1 匹ずつはいることが分かっているものとします。 推定されるパイザ鶴やパイザ亀の匹数がどちらか一方でも正の整数にならないときや、一意に定まらない場合は頭や足の数を数え間違えた可能性があるので、その場合は "miss" と出力してください。

//例えば、足が合計 32 本、頭が合計 10 個であり、パイザ鶴とパイザ亀の一匹あたりの足の本数がそれぞれ 2 本と 4 本の場合は、以下の図のようにパイザ鶴 4 匹とパイザ亀 6 匹が答えとなります(入力例 1)。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    class B038
    {
        public static void Main()
        {
            var input = System.Console.ReadLine();

            if (input.Split(' ').Length != 4)
            {
                return;
            }

            int a = Convert.ToInt32(input.Split(' ')[0]);
            int b = Convert.ToInt32(input.Split(' ')[1]);
            int c = Convert.ToInt32(input.Split(' ')[2]);
            int d = Convert.ToInt32(input.Split(' ')[3]);

            if (a < 0 || a > 100 ||
                b < 0 || b > 100 ||
                c < 0 || c > 100 ||
                d < 0 || d > 100)
            {
                return;
            }

            int resultX = 0;
            int resultY = 0;
            bool ok = false;

            for (int x = 1; x <= b; x++)
            {
                if (ok == true)
                {
                    break;
                }

                for (int y = 1; y < b; y++)
                {
                    if (ok == true)
                    {
                        break;
                    }
                    if (x + y == b && (c * x) + (d * y) == a)
                    {
                        resultX = x;
                        resultY = y;
                        ok = true;
                    }
                }
            }

            if (ok == true)
            {
                System.Console.WriteLine(resultX + " " + resultY);
            }
            else
            {
                System.Console.WriteLine("miss");
            }
        }
    }
}
