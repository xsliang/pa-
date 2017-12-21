//あなたは正の整数の掛け算のみをする計算機のプログラムを作成しています。
//その計算機は最大で4桁までしか表示できず 9,999 より大きな数字は表示が出来ず "NG" と表示されます。

//2つの正の整数 a, b が入力されるので、a と bを掛け算した時 9,999 以下であれば掛け算した結果を出力し、10,000 以上の場合は "NG" と出力するプログラムを作成してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D077
    {
        public static void Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                int a = Convert.ToInt32(line.Split(' ')[0]);
                int b = Convert.ToInt32(line.Split(' ')[1]);

                if (a >= 1 && a <= 9999 &&
                    b >= 1 && b <= 9999)
                {
                    if (a * b > 10000)
                    {
                        System.Console.WriteLine("NG");
                    }
                    else
                    {
                        System.Console.WriteLine(a * b);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
