// D024:三角形の内角の和

//平面上の三角形の内角の和は全て足すと 180 度になります。

//平面上の三角形の 2 つの角の角度 a, b が改行区切りで与えられるので残りの 1 つの角の角度を出力して下さい。

//例えば以下のような入力の場合

//    60
//    90

//以下のように出力して下さい

//    30

using System;
public class D024
{
    public static void Main()
    {
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        if (Convert.ToInt32(line1) >= 1 && Convert.ToInt32(line1) <= 179 &&
        Convert.ToInt32(line2) >= 1 && Convert.ToInt32(line2) <= 179)
        {
            int a = Convert.ToInt32(line1);
            int b = Convert.ToInt32(line2);
            if (a + b >= 2 && a + b <= 179)
            {
                System.Console.WriteLine(180 - (a + b));
            }
        }

    }
}

