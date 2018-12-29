

using System;
public class D013
{
    public static void D013Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line.Split(' ')[0]) >= 1 && Convert.ToInt32(line.Split(' ')[0]) <= 100 &&
        Convert.ToInt32(line.Split(' ')[1]) >= 1 && Convert.ToInt32(line.Split(' ')[1]) <= 100)
        {
            int m = Convert.ToInt32(line.Split(' ')[0]);
            int n = Convert.ToInt32(line.Split(' ')[1]);

            System.Console.WriteLine(m / n + " " + m % n);
        }
    }
}
