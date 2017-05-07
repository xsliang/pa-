//x,y二次元平面上の地点 x = 0[m] の高さ o_y[m] に矢の中心を置き初速 s[m / s] で x水平面に対して角度θ[度] で投げます。
//距離x[m] の地点の高さ y[m] の位置を中心に直径 a[m] の的が図のようにy軸に平行に立ててあります。
//この際、空気抵抗等は無いものとして的に矢の中心の軌道が当たるかどうか判定し、当たった場合、的の中心からの距離を小数点第2位で四捨五入 した小数点第1位までの数値を出力してください。
//矢の軌道を求める式は以下のようになります。

//重力加速度gは 9.8[m/s^2]
//とします。

//    10個のテストケースの内、全てのテストケースにおいて以下の条件を満たします。
//以下の範囲で整数値
//0 ≦ o_y[初期位置の高さ m] ≦ 100
//1 ≦ [初速 m/s] ≦ 100
//0 ≦ θ[度] ≦ 90
//1 ≦ x[的までの距離 m] ≦ 100
//0 ≦ y[的の高さ m] ≦ 100
//1 ≦ a[的の直径 m] ≦ 100
//重力加速度は小数値で以下のように定義します。
//g[重力加速度 m / s ^ 2] = 9.8
//また、浮動小数の誤差が起こることを考慮しテストケースの矢の軌道は的の端0.05の範囲は通らないものとして入力されます。

using System;

namespace paiza.B
{
    public class B006
    {
        public static void Main()
        {
            // 自分の得意な言語で
            // Let's チャレンジ！！

            try
            {
                var line = System.Console.ReadLine();
                string[] date1 = line.Split(' ');
                double o_y = Convert.ToDouble(date1[0]);
                double s = Convert.ToDouble(date1[1]);
                double seta = Convert.ToDouble(date1[2]);

                if (o_y < 0 || o_y > 100)
                {
                    return;
                }

                if (s < 1 || s > 100)
                {
                    return;
                }

                if (seta < 0 || seta > 90)
                {
                    return;
                }

                seta = Math.PI / 180 * seta;

                var line2 = System.Console.ReadLine();

                string[] date2 = line2.Split(' ');
                double x = Convert.ToDouble(date2[0]);
                double y = Convert.ToDouble(date2[1]);
                double a = Convert.ToDouble(date2[2]);

                if (x < 1 || x > 100)
                {
                    return;
                }

                if (y < 0 || y > 100)
                {
                    return;
                }

                if (a < 1 || a > 100)
                {
                    return;
                }

                double g = 9.8d;

                double new_y = o_y + (x * Math.Tan(seta)) - (g * x * x / (2 * s * s * (Math.Cos(seta)) * (Math.Cos(seta))));

                double result = Math.Round(Math.Abs(y - new_y), 1, MidpointRounding.AwayFromZero);
                if (new_y < (y - a / 2) || new_y > (y + a / 2))
                {
                    System.Console.WriteLine("Miss");

                }
                else
                {
                    System.Console.WriteLine("Hit " + result);
                }
            }
            catch
            {

            }

        }
    }
}
