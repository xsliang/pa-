

using System;
public class D031
{
    public static void D031Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            System.Console.WriteLine(n * 60);
        }
    }
}
