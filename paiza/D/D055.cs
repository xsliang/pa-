//あなたはあるワインの銘柄のマーケティングを担当しています。良いキャッチコピーを考えるため、とりあえず「〜の中で最高」というフレーズを色々作ってみることにしました。

//2 つの文字列が与えられるので、"Best in" とそれらの文字列をすべて半角スペース区切りで結合して出力してください。

//例)

//hundred years → Best in hundred years

//the universe → Best in the universe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D055
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            string abc = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            try
            {
                string s1 = line.ToString().Split(' ')[0];
                string s2 = line.ToString().Split(' ')[1];
                if (s1.Length >= 1 && s1.Length <= 20 &&
                s2.Length >= 1 && s2.Length <= 20)
                {
                    foreach (var text in s1)
                    {
                        if (abc.Contains(text.ToString()) == false)
                        {
                            return;
                        }
                    }
                    foreach (var text in s2)
                    {
                        if (abc.Contains(text.ToString()) == false)
                        {
                            return;
                        }
                    }
                    System.Console.WriteLine("Best in " + s1 + " " + s2);
                }

            }
            catch
            {

            }

        }
    }

}
