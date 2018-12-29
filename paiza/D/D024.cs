

using System;
public class D024
{
    public static void D024Main()
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

