//ひな祭りの準備をしましょう。あなたが持っている 10 体の人形を "A", "B", "C", "D", "E", "F", "G", "H", "I", "J" で表します。ひな壇の各段(計 3 段) に並べる人形の数が与えられるので、各段にならべる人形の記号を改行区切りで出力してください。人形は必ずもとの A, B, C, ... の順番で並べます。

//例)

//各段にならべる人形の数: 2, 3, 5

//→ 人形の並べ方:

//AB
//CDE
//FGHIJ

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D062
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                int h1 = Convert.ToInt32(line.ToString().Split(' ')[0]);
                int h2 = Convert.ToInt32(line.ToString().Split(' ')[1]);
                int h3 = Convert.ToInt32(line.ToString().Split(' ')[2]);
                if (h1 >= 1 && h1 <= 10 &&
                h2 >= 1 && h2 <= 10 &&
                h3 >= 1 && h3 <= 10 &&
                h1 + h2 + h3 == 10)
                {
                    string temp = "ABCDEFGHIJ";
                    System.Console.WriteLine(temp.Substring(0, h1));
                    System.Console.WriteLine(temp.Substring(h1, h2));
                    System.Console.WriteLine(temp.Substring(h2 + h1, h3));
                }
            }
            catch
            {

            }

        }
    }

}
