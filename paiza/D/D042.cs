

using System;

public class D042
{
    public static void D042Main()
    {
        
        
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        try
        {
            int n1 = Convert.ToInt32(line1.Split(' ')[0]);
            int n2 = Convert.ToInt32(line1.Split(' ')[1]);
            int n3 = Convert.ToInt32(line2.Split(' ')[0]);
            int n4 = Convert.ToInt32(line2.Split(' ')[1]);

            if (-1000 <= n1 && n1 <= 1000 &&
            -1000 <= n2 && n2 <= 1000 &&
            -1000 <= n3 && n3 <= 1000 &&
            -1000 <= n4 && n4 <= 1000)
            {
                int result = n1 * n4 - n2 * n3;
                System.Console.WriteLine(result.ToString());
            }
        }
        catch
        {

        }
    }
}