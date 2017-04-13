//あなたはエイプリルフールに冗談で書かれたソースコードを修正する作業に追われています。
//そのソースコードは「True」と書くべきところが全て「False」となっています。

//文字列が 1 行で与えられるので文字列に含まれる「False」を「True」に置き換えて出力してください。
//置き換えが必要ない場合もそのまま文字列を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D064
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                if (line.Length >= 1 && line.Length <= 100)
                {
                    string result = line.Replace("False", "True");
                    System.Console.WriteLine(result);
                }
            }
            catch
            {

            }

        }
    }

}
