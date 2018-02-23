
//あなたは体調管理のために天気予報の最高気温、最低気温から 1 日の気温がいくつ変化しているかを知りたくなりました。

//ある日の最高気温 t と最低気温 u がスペース区切りで入力されるので、 1 日の気温がいくつ変化しているかを出力してください。

//例えば以下のように入力された場合、最高気温が 7 度、最低気温が -3 度を意味し

//    7 -3

//温度の差は 10 なので以下のように出力してください。

//    10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D088
    {
        public static void Main()
        {
            var line = System.Console.ReadLine();

            int t = Convert.ToInt32(line.Split(' ')[0]);
            int u = Convert.ToInt32(line.Split(' ')[1]);

            if (t < -40 || t > 40 || u < -40 || u > 40 || u >= t)
            {
                return;
            }
            else
            {
                System.Console.WriteLine(t - u);
            }
        }
    }
}
