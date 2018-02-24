//入力される文字数 n と n 文字分の文字が1文字ずつ改行区切りで入力されます。
//n 個の文字を全て結合し1つの文字列として1行で出力してください。

//例えば以下のように入力された場合

//    5
//    P
//    a
//    i
//    z
//    a

//以下のように出力してください。

//    Paiza

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D087
    {
        public static void Main()
        {
            var line = System.Console.ReadLine();
            int count = Convert.ToInt32(line);
            if (count < 1 || count > 10)
            {
                return;
            }
            string[] result =new string[count];
            for (int i = 0; i < count; i++)
            {
                result[i] = System.Console.ReadLine();
            }

            System.Console.WriteLine(String.Join("", result));
        }
    }
}
