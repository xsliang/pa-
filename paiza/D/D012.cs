

using System;
public class D012
{
    public static void D012Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= -100 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            if (n < 0)
            {
                n = 0 - n;
            }
            System.Console.WriteLine(n);
        }
    }
}
