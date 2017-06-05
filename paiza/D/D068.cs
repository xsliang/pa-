//あなたは文字列として記録された天気の分析をしています。
//その文字列は晴れの日を "S" 雨の日を "R" とし、 1 日ごとに記録していった長さ n の文字列です。

//文字列に記録された晴れの日数と、雨の日数をスペース区切りで出力してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D068
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(line);
                var line2 = System.Console.ReadLine();
                int s = 0;
                int r = 0;
                foreach (char item in line2)
                {
                    if (item == 'S')
                    {
                        s++;
                    }
                    else if (item == 'R')
                    {
                        r++;
                    }
                }
                System.Console.WriteLine(s + " " + r);
            }
            catch
            {
            }

        }
    }
}
