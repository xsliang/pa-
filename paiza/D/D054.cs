

using System;
public class D054
{
    public static void D054Main()
    {
        
        
        var line = System.Console.ReadLine();
        try
        {
            if (line.ToString().Length >= 1 && line.ToString().Length <= 20)
            {
                if (line.ToString().Length >= 11)
                {
                    System.Console.WriteLine("OK");
                }
                else
                {
                    int result = 11 - line.ToString().Length;
                    System.Console.WriteLine(result.ToString());
                }
            }
        }
        catch
        {

        }
    }
}
