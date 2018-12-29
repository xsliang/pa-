

using System;
public class D037
{
    public static void D037Main()
    {
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        try
        {
            int M = Convert.ToInt32(line1);
            int N = Convert.ToInt32(line2);
            if (1 <= M && M <= 100 && 1 <= N && N <= 100)
            {
                double result = Convert.ToDouble(N) / Convert.ToDouble(M);
                double realResult = Math.Ceiling(result);

                System.Console.WriteLine(realResult);
            }
        }
        catch
        {

        }
    }
}
