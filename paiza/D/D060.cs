
//あなたは A のボタン、 B のボタンの 2 つのボタンを使うゲームを作っています。

//このゲームではキャラクターを動かして遊びます。キャラクターははじめ座標 0 の位置にいて、A のボタンを押すとキャラクターが 1 マス右に進み(座標が 1 増える)、 B のボタンを押すとキャラクターが 1 マス左に進み(座標が 1 減る) ます。

//A, B のボタンそれぞれ何回押したが入力されるので、ボタンが全て押された後のキャラクターの位置の座標を出力するプログラムを作成してください。
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D060
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                int a = Convert.ToInt32(line.Split(' ')[0]);
                int b = Convert.ToInt32(line.Split(' ')[1]);
                if (0 <= a && a <= 100 && 0 <= b && b <= 100)
                {
                    System.Console.WriteLine(0 + a - b);
                }
            }
            catch
            {

            }

        }
    }

}
