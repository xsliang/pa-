// D013:割り算

//整数 m と n 与えられます。

//m を n で割り算した商と余りを出力して下さい。

using System;
public class D013
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line.Split(' ')[0]) >= 1 && Convert.ToInt32(line.Split(' ')[0]) <= 100 &&
        Convert.ToInt32(line.Split(' ')[1]) >= 1 && Convert.ToInt32(line.Split(' ')[1]) <= 100)
        {
            int m = Convert.ToInt32(line.Split(' ')[0]);
            int n = Convert.ToInt32(line.Split(' ')[1]);

            System.Console.WriteLine(m / n + " " + m % n);
        }
    }
}
