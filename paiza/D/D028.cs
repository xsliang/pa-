

using System;
public class D028
{
    public static void D028Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 10000)
        {
            int n = Convert.ToInt32(line);
            System.Console.WriteLine(n.ToString().Length);
        }

    }
}
