

using System;
public class D046
{
    public static void D046Main()
    {
        
        
        var line = System.Console.ReadLine();
        try
        {
            int d_1 = Convert.ToInt32(line.Split(' ')[0]);
            int d_2 = Convert.ToInt32(line.Split(' ')[1]);
            int d_3 = Convert.ToInt32(line.Split(' ')[2]);
            if (1 <= d_1 && d_1 <= 100 &&
            1 <= d_2 && d_2 <= 100 &&
            1 <= d_3 && d_3 <= 100)
            {
                int result = 0;
                result = d_1;
                if (result < d_2)
                {
                    result = d_2;
                }
                if (result < d_3)
                {
                    result = d_3;
                }
                System.Console.WriteLine(result.ToString());
            }
        }
        catch
        {

        }
    }
}
