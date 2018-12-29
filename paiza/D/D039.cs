

using System;
public class D039
{
    public static void D039Main()
    {
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        var line3 = System.Console.ReadLine();
        try
        {
            int a = Convert.ToInt32(line1);
            int b = Convert.ToInt32(line2);
            int c = Convert.ToInt32(line3);
            if (1 <= a && a <= 100 &&
            1 <= b && b <= 100 &&
            1 <= b && b <= 100 &&
            a == b && a == c && b == c)
            {
                System.Console.WriteLine("YES");
            }
            else
            {
                System.Console.WriteLine("NO");
            }

        }
        catch
        {

        }
    }
}
