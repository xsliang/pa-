//あなたの友人である K 氏は電子工作が大好きです。
//彼は毎晩試行錯誤を重ね、最近ついにコンピュータのミニチュア版を開発することに成功しました。

//彼のコンピュータはちょうど 2 つの変数を持っており、どちらの変数も 0 で初期化されています。
//また、彼のコンピュータは次の 3 種類の命令を実行することができます。

//・SET i a : 変数 i に値 a を代入する(i = 1, 2)
//・ADD a :「変数 1 の値 + a」を計算し、計算結果を変数 2 に代入する
//・SUB a :「変数 1 の値 - a」を計算し、計算結果を変数 2 に代入する

//彼は、自分のコンピュータが正しく動いているかどうかチェックしてほしいと依頼してきました。
//コンピュータが完成して嬉しそうな彼の頼みを断るわけにはいきません。
//そんな彼のために、彼のコンピュータをシミュレートするプログラムを書きましょう。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C024
    {
        public static void Main()
        {
            var line = System.Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(line);
                if (n >= 1 && n <= 10)
                {
                    int i1 = 0;
                    int i2 = 0;
                    for (int i = 0; i < n; i++)
                    {
                        var line2 = System.Console.ReadLine();
                        string[] proc = line2.Split(' ');
                        if (proc[0].ToUpper() == "SET")
                        {
                            int a = Convert.ToInt32(proc[2]);
                            if (a >= -1000 && a <= 1000)
                            {
                                if (proc[1] == "1")
                                {
                                    i1 = a;
                                }
                                else if (proc[1] == "2")
                                {
                                    i2 = a;
                                }
                            }
                        }
                        else if (proc[0].ToUpper() == "ADD")
                        {
                            int a = Convert.ToInt32(proc[1]);
                            if (a >= -1000 && a <= 1000)
                            {
                                i2 = i1 + a;
                            }
                        }
                        else if (proc[0].ToUpper() == "SUB")
                        {
                            int a = Convert.ToInt32(proc[1]);
                            if (a >= -1000 && a <= 1000)
                            {
                                i2 = i1 - a;
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    System.Console.WriteLine(i1 + " " + i2);
                }
            }
            catch
            {
            }

        }
    }
}
