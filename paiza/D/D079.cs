//あなたはパスワードを入力させるプログラムを作成しています。
//単純なパスワード入力を防ぐために手始めに 全ての文字が同じ パスワードであった場合に警告を出すことにしました。

//例えば、以下のような全てが "A" の文字列

//    AAAAAAAA

//の場合は

//    NG

//と出力し、以下のような異なる文字が含まれる文字列

//    ABBBBBB

//の場合は

//    OK

//と出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D079
    {
        public static void Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                if (line.Length >= 2 && line.Length <= 100)
                {
                    string one = line[0].ToString();

                    bool result = true;

                    foreach (char item in line)
                    {
                        if (item.ToString() != one)
                        {
                            result = false;
                            break;
                        }
                    }

                    if (result == true)
                    {
                        System.Console.WriteLine("NG");
                    }
                    else
                    {
                        System.Console.WriteLine("OK");
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
