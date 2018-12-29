

using System;
public class D015
{
    public static void D015Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            while (n != 0)
            {
                System.Console.WriteLine(n);
                n--;
            }
        }
    }
}

