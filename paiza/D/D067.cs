//あなたはスイッチの状態を表示するプログラムを作成しています。
//そのスイッチは1度押すと "ON" と "OFF" が切り替わります。

//スイッチの初期状態は "OFF" でスイッチを押した回数 n が入力されるので n 回スイッチが押された後の状態を出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D067
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(line);
                if (1 <= n && n <= 100)
                {
                    if (n % 2 == 0)
                    {
                        System.Console.WriteLine("OFF");
                    }
                    else
                    {
                        System.Console.WriteLine("ON");
                    }
                }

            }
            catch
            {
            }

        }
    }
}
