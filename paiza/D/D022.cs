

using System;
public class D022
{
    public static void D022Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 20)
        {
            int n = Convert.ToInt32(line);
            System.Console.WriteLine(6 * n * n);
        }
    }
}
