

using System;
public class D027
{
    public static void D027Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 2 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            System.Console.WriteLine((1 + n) * n / 2);
        }
    }
}

