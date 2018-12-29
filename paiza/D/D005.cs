
using System;
public class D005
{
    public static void D005Main()
    {
        var line = System.Console.ReadLine();
        string[] aryLine = line.Split(' ');
        if (Convert.ToInt32(aryLine[0]) >= 1 && Convert.ToInt32(aryLine[0]) <= 100 &&
        Convert.ToInt32(aryLine[1]) >= 1 && Convert.ToInt32(aryLine[1]) <= 100)
        {
            int m = Convert.ToInt32(aryLine[0]);
            int n = Convert.ToInt32(aryLine[1]);
            int[] aryResult = new int[10];
            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                {
                    result = m;
                }
                else
                {
                    result = result + n;
                }
                aryResult[i] = result;
            }
            System.Console.WriteLine(string.Join(" ", aryResult));
        }
    }
}
