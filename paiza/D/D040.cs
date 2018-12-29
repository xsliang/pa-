

using System;
public class D040
{
    public static void D040Main()
    {
        
        
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
