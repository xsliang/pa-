

using System;
public class D016
{
    public static void D016Main()
    {
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        if (line1.Length >= 1 && line1.Length <= 100 &&
        Convert.ToInt32(line2) >= 1 && Convert.ToInt32(line2) <= line1.Length)
        {
            int n = Convert.ToInt32(line2);
            System.Console.WriteLine(line1.Substring(0, n));
        }
    }
}
