//今日は大雪、子どもたちはかまくらをつくろうとはしゃいでいます。どれだけの体積の雪が必要かを計算してあげましょう。

//かまくらは 1 辺が r1(m) の立方体から r2(m) の立方体分をくり抜く形でつくります(以下の図参照)。このときかまくらの体積(m^3)は

//r1^3 - r2^3

//で求められます。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    using System;
    public class D056
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                int r_1 = Convert.ToInt32(line.Split(' ')[0]);
                int r_2 = Convert.ToInt32(line.Split(' ')[1]);
                if (1 <= r_1 && r_1 > r_2 && r_1 <= 20 && r_2 <= 20)
                {
                    System.Console.WriteLine(r_1 * r_1 * r_1 - r_2 * r_2 * r_2);
                }
            }
            catch
            {

            }

        }
    }

}
