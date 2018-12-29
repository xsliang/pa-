

using System;
public class D043
{
    public static void D043Main()
    {
        
        
        var line = System.Console.ReadLine();
        try
        {
            int n = Convert.ToInt32(line);
            if (0 <= n && n <= 100)
            {
                if (0 <= n && n <= 30)
                {
                    System.Console.WriteLine("sunny");
                }
                else if (n >= 31 && n <= 70)
                {
                    System.Console.WriteLine("cloudy");
                }
                else if (n >= 71)
                {
                    System.Console.WriteLine("rainy");
                }
            }
        }
        catch
        { }
    }
}
