

using System;
public class D025
{
    public static void D025Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            if (line.Length == 1)
            {
                line = "00" + line;
            }
            else if (line.Length == 2)
            {
                line = "0" + line;
            }
            System.Console.WriteLine(line);
        }
    }
}
