//あなたは整数を足して 21 を目指すゲームをプレイするプログラムを作成しています。

//そのゲームでは、はじめに 2 つの数字を受け取り、更に数字を受け取るかどうかの判断をします。
//受け取る場合は "HIT" 、受け取らない場合は "STAND" と出力するルールになっています。

//以下のルールで "HIT" もしくは "STAND" を出力するプログラムを作成してください。

//・2つの数字の合計が 16 未満であれば "HIT"
//・2つの数字の合計が 16 以上であれば "STAND"

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D083
    {
        public static void Main()
        {
            var line = System.Console.ReadLine();

            int M = Convert.ToInt32(line.Split(' ')[0]);
            int N = Convert.ToInt32(line.Split(' ')[1]);

            if (M < 1 || M > 13 || N < 1 || N > 13)
            {
                return;
            }

            if (N + M < 16)
            {
                Console.WriteLine("HIT");
            }
            else
            {
                Console.WriteLine("STAND");
            }
        }
    }
}
