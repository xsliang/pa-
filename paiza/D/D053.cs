//Trick or Treat! ハロウィーンのシーズンです。あなたの子供はわがままなのでお菓子といってもキャンディかチョコレートでないと満足してくれません。

//文字列が与えられるので、これが "candy" か "chocolate" であれば "Thanks!"、その他の場合は "No!" という子供のリアクションを出力してください。

//例)
//candy → Thanks!
//chocolate → Thanks!
//icecream → No!
//senbei → No! 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D053
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！
            var line = System.Console.ReadLine();
            try
            {
                if (line.ToString().Length >= 1 && line.ToString().Length <= 20)
                {
                    switch (line)
                    {
                        case "chocolate":
                        case "candy":
                            System.Console.WriteLine("Thanks!");
                            break;
                        default:
                            System.Console.WriteLine("No!");
                            break;
                    }
                }
            }
            catch
            {

            }

        }
    }

}
