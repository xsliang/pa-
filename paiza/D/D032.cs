

using System;
public class D032
{
    public static void D032Main()
    {
        
        
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 0 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            System.Console.WriteLine(100 - n);
        }
    }
}
