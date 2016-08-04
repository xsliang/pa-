// D040:連休の天気

//あなたは7日間の連休をもらいましたが、降水確率が 30% 以下ならば外に出掛ける事に決めました。
//7日間の降水確率(%)が改行区切りで入力されるので、出掛ける日数の合計を出力してください。

//例えば

//    13
//    0
//    15
//    30
//    89
//    100
//    31

//と与えられた場合

//    4

//と出力するプログラムを作成してください。

using System;
public class D040
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        var line3 = System.Console.ReadLine();
        var line4 = System.Console.ReadLine();
        var line5 = System.Console.ReadLine();
        var line6 = System.Console.ReadLine();
        var line7 = System.Console.ReadLine();
        try
        {
            int t1 = Convert.ToInt32(line1);
            int t2 = Convert.ToInt32(line2);
            int t3 = Convert.ToInt32(line3);
            int t4 = Convert.ToInt32(line4);
            int t5 = Convert.ToInt32(line5);
            int t6 = Convert.ToInt32(line6);
            int t7 = Convert.ToInt32(line7);

            if (0 <= t1 && t1 <= 100 &&
            0 <= t2 && t2 <= 100 &&
            0 <= t3 && t3 <= 100 &&
            0 <= t4 && t4 <= 100 &&
            0 <= t5 && t5 <= 100 &&
            0 <= t6 && t6 <= 100 &&
            0 <= t7 && t7 <= 100)
            {
                int count = 0;
                if (t1 <= 30) count++;
                if (t2 <= 30) count++;
                if (t3 <= 30) count++;
                if (t4 <= 30) count++;
                if (t5 <= 30) count++;
                if (t6 <= 30) count++;
                if (t7 <= 30) count++;
                System.Console.WriteLine(count);
            }
        }
        catch
        {

        }
    }
}
