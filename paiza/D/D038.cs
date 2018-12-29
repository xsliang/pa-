

using System;
public class D038
{
    public static void D038Main()
    {
        var line = System.Console.ReadLine();
        try
        {
            int N = Convert.ToInt32(line);
            if (2 <= N && N <= 100)
            {
                int result = N * (N - 1) / 2;
                System.Console.WriteLine(result);
            }
        }
        catch
        {

        }
    }
}
