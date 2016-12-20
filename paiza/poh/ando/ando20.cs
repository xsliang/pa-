//あなたは毎日朝7時に起きて、残業がなければ8時間働いて、6時間眠ります。
//残業のあった日は疲れるので、残業した時間の1/3だけ、睡眠時間が増えます。

//きちんと朝7時に起きるためには、前日の何時何分に寝ればよいかを計算してください。
//幸い、あなたの会社は3分刻みで残業時間を記録するので、何秒に寝ればよいかを考える必要はありません。

//睡眠、仕事、残業 以外の時間は空き時間となります。

// 条件

//すべてのテストケースにおいて、以下の条件をみたします。

//1 ≦ N ≦ 100
//0 ≦ m ≦ 450 (m は3の倍数)

// 期待する出力

//あなたが寝る時間をN行、24時間表記で(時間):(分)の形式で、 改行区切りで出力してください。 分が1桁の場合でも、0を付けて2桁にしてください。(例 09:07)

//23:59を超える場合は、00:00に戻して表示してください。

//例1 25:00 → 01:00
//例2 24:15 → 00:15
//最後は改行し、余計な文字、空行を含んではいけません。

using System;
public class Hello
{
    public static void Main()
    {
        // 自分の得意な言語で
        // Let's チャレンジ！！
        try
        {
            var line = System.Console.ReadLine();
            int count = Convert.ToInt32(line);
            int[] aryM = new int[count];
            if (count >= 1 && count <= 100)
            {
                for (int i = 0; i < count; i++)
                {
                    var line2 = System.Console.ReadLine();
                    int m = Convert.ToInt32(line2);
                    if (m < 0 || m > 450 || m % 3 != 0)
                    {
                        return;
                    }
                    aryM[i] = m / 3;
                }

                for (int i = 0; i < count; i++)
                {
                    int time = aryM[i];
                    if (time == 0)
                    {
                        System.Console.WriteLine("01:00");
                    }
                    else if (time <= 60)
                    {
                        time = 60 - time;
                        if (time < 10)
                        {
                            System.Console.WriteLine("00:0" + time.ToString());
                        }
                        else
                        {
                            System.Console.WriteLine("00:" + time.ToString());
                        }
                    }
                    else
                    {
                        int hour = 24 - (time / 60);
                        int minute = 60 - (time % 60);
                        if (minute == 60)
                        {
                            hour = hour + 1;
                            minute = 0;
                        }
                        if (minute < 10)
                        {
                            System.Console.WriteLine(hour.ToString() + ":0" + minute.ToString());
                        }
                        else
                        {
                            System.Console.WriteLine(hour.ToString() + ":" + minute.ToString());
                        }
                    }
                }
            }
        }
        catch
        {

        }
    }
}

