//using System;
//あなたはとある数値の集計をするプログラムを作成しています。文字列で保存された記録から数字のみを取り出したいです。

//対象の文字列は数字が0以上の整数値 n 、単位が必ず1文字以上の半角アルファベットで構成された文字列 s が結合した形で表されます。

//結合された文字列から整数値 n だけを出力するプログラムを作成してください。

//例えば

//    100paiza

//と入力があった場合 paiza が単位となり 100 が取り出したい数値となるので

//    100

//と出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D089
    {
        public static void Main()
        {
            var line = System.Console.ReadLine();

            string temp = string.Empty;

            foreach (char item in line)
            {
                if ("1234567890".Contains(item))
                {
                    temp = temp + item.ToString();
                }
            }

            int tempInt = Convert.ToInt32(temp);

            if (tempInt >= 0 && tempInt <= 100)
            {
                System.Console.WriteLine(temp);
            }


        }
    }
}
