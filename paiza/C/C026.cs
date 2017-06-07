//Rabbit社の社長はウサギが大好きで、 社内で1匹のウサギを飼育することにしました。
//ウサギが人参を好むことは広く知られています。 また、ウサギに詳しい社員によると、 人参は糖分が多いため与えすぎるのは良くないようです。

//そこで、人参は1日1本だけ与えることにし、 特に糖分が許容範囲内で質量が大きい人参を選ぶことにしました。

//プログラマーであるあなたはRabbit社の依頼を受け、 1 から N で番号付けられた N 個の人参のデータを入力として、 糖分が許容範囲内で質量の最も大きい人参を見つけるプログラムを作成することになりました。

//糖分には基準値Sと許容誤差 p があり、 糖分が S - p 以上 S + p 以下ならば許容範囲内となります。
//また、糖分が許容範囲内で質量の最も大きい人参 が複数ある場合は、それらのうち番号の最も小さいものを知ることができれば十分です。

//例えば、入力例1は以下のようになっています。


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C026
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            try
            {
                int number = 0;
                int weight = 0;
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line.Split(' ')[0]);
                if (N < 3 || N > 100)
                {
                    return;
                }
                int S = Convert.ToInt32(line.Split(' ')[1]);
                if (S < 1 || S > 100)
                {
                    return;
                }
                int p = Convert.ToInt32(line.Split(' ')[2]);
                if (p < 0 || p > 10)
                {
                    return;
                }
                for (int i = 0; i < N; i++)
                {
                    var line2 = System.Console.ReadLine();
                    int m = Convert.ToInt32(line2.Split(' ')[0]);
                    int s = Convert.ToInt32(line2.Split(' ')[1]);
                    if (m < 1 || m > 100 || s < 1 || s > 100)
                    {
                        return;
                    }
                    if ((S - p) <= s && s <= (S + p))
                    {
                        if (weight < m)
                        {
                            weight = m;
                            number = i + 1;
                        }
                    }
                }

                if (number > 0)
                {
                    System.Console.WriteLine(number);
                }
                else
                {
                    System.Console.WriteLine("not found");
                }

            }
            catch
            {
            }

        }
    }
}
