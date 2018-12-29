


using System;
public class D041
{
    public static void D041Main()
    {
        var line = System.Console.ReadLine();
        if (line.Split(' ').Length == 3)
        {
            int n = Convert.ToInt32(line.Split(' ')[0]);
            int d = Convert.ToInt32(line.Split(' ')[1]);
            int e = Convert.ToInt32(line.Split(' ')[2]);
            if (1 <= n && n <= 500 &&
            1 <= d && d <= 10 &&
            1 <= e && e <= 500)
            {
                if (n <= d * e)
                {
                    System.Console.WriteLine("OK");
                }
                else
                {
                    System.Console.WriteLine("NG");
                }
            }
            else
            {
                System.Console.WriteLine("NG");
            }
        }
    }
}

