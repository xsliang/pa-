

using System;
public class ando20
{
    public static void ando20Main()
    {
        
        
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

