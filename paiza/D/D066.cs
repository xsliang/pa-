//あなたはソーシャルゲームで遊んでいます。

//ステージに挑戦するためにスタミナと呼ばれる数値を m 消費します。

//あなたの現在のスタミナ n が与えられるので、ステージに挑戦可能であれば挑戦した後のスタミナの数値、挑戦が不可能な場合は "No" を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D066
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                int m = Convert.ToInt32(line.Split(' ')[0]);
                int n = Convert.ToInt32(line.Split(' ')[1]);
                if (1 <= m && m <= 20 && 1 <= n && n <= 20)
                {
                    if (n-m>=0)
                    {
                        System.Console.WriteLine(n - m);
                    }
                    else
                    {
                        System.Console.WriteLine("No");
                    }
                }
                
            }
            catch
            {
            }

        }
    }
}
