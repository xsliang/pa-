// D006:単位の計算

//距離 n とその単位 s がスペース区切りで与えられるので、すべての距離をmmに換算し出力してください。

//入力される距離の単位は km, m, cm の3種類で、それぞれ以下のように換算出来ます。

//    1km = 1000m 
//    1m = 100cm 
//    1cm = 10mm


//例えば

//入力例
//    1 km

//と入力された場合、1×1000×100×10という式になり

//出力例
//    1000000

//と出力して下さい。
using System;
public class D006
{
    public static void Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line.Split(' ')[0]) >= 1 && Convert.ToInt32(line.Split(' ')[0]) <= 1000)
        {
            int n = Convert.ToInt32(line.Split(' ')[0]);
            string unit = line.Split(' ')[1];
            switch (unit)
            {
                case "km":
                    System.Console.WriteLine(n + "000000");
                    break;
                case "m":
                    System.Console.WriteLine(n + "000");
                    break;
                case "cm":
                    System.Console.WriteLine(n + "0");
                    break;
            }
        }
    }
}
