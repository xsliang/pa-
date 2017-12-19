// あなたは禁止ワードが含まれるかどうかを判定するプログラムを作成しています。

//禁止ワード W と判定する文字列 S が改行区切りで順に与えられるので S に W が含まれている時は "NG" それ以外の場合は文字列 S をそのまま出力してください。

//例えば入力例 1 の場合

//    ngword
//    thisisngword

//"ngword" が "thisisngword" 内に含まれているので

//    NG

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D076
    {
        public static void Main()
        {
            try
            {

                var w = System.Console.ReadLine();
                var s = System.Console.ReadLine();

                if (w.Length >= 1 && w.Length <= 100 &&
                    s.Length >= 1 && s.Length <= 100)
                {
                    if (s.Contains(w))
                    {
                        System.Console.WriteLine("NG");
                    }
                    else
                    {
                        System.Console.WriteLine(s);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
