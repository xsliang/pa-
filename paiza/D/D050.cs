
using System;
public class D050
{
    public static void D050Main()
    {
        
        
        var line = System.Console.ReadLine();
        try
        {
            int d1 = Convert.ToInt32(Convert.ToString(line).Split(' ')[0]);
            int d2 = Convert.ToInt32(Convert.ToString(line).Split(' ')[1]);
            if (1 <= d1 && d1 <= 1000 && 1 <= d2 && d2 <= 1000)
            {
                if (d1 > 5)
                {
                    d1 = 5;
                }
                if (d2 > 5)
                {
                    d2 = 5;
                }

                System.Console.WriteLine(d1 + d2);
            }
        }
        catch
        {

        }
    }
}
