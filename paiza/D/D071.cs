//あなたは洗濯物を干すかどうか、その日の気温と湿度で決めることにしました。
//暖かくて乾燥してる日を選んで干したいところですが、家の向には公園があり、そういった日は砂ぼこりが舞ってしまいます。

//そこであなたは干すためのルールを決めました。

//気温が 25 ℃以上の日、もしくは湿度が 40 % 以下の日は干します。それ以外の日は干しません。
//ただし、上記の干す条件を満たす日のうち、気温が 25 ℃以上かつ、湿度 40 % 以下の日は砂ぼこりが舞うので干しません。

//例えば、気温が 30 ℃で湿度が 60 % の日は温かいので干しますが、同じ気温で湿度が 20 % の日は砂ぼこりが舞うので干しません。

//その日の気温と湿度が与えられるので、干すかどうか判断してください。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D071
    {
        public static void Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                string[] aryLine = line.Split(' ');
                int t = Convert.ToInt32(aryLine[0]);
                int m = Convert.ToInt32(aryLine[1]);
                if (t >= 0 && m >= 0 && t <= 40 && m <= 100)
                {
                    if (t >= 25 || m <= 40)
                    {
                        if (t >= 25 && m <= 40)
                        {
                            System.Console.WriteLine("No");
                        }
                        else
                        {
                            System.Console.WriteLine("Yes");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No");
                    }

                }



            }
            catch (Exception ex)
            {
            }
        }
    }
}
