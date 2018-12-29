

using System;
public class D034
{
    public static void D034Main()
    {
        
        
        try
        {
            var line = System.Console.ReadLine();
            if (Convert.ToInt32(line) >= 2 && Convert.ToInt32(line) <= 21)
            {
                int n = Convert.ToInt32(line);
                if (21 % n == 0)
                {
                    System.Console.WriteLine(n);
                }
                else
                {
                    System.Console.WriteLine(21 % n);
                }
            }
        }
        catch
        { }
    }
}
