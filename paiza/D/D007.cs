
using System;
public class D007
{
    public static void D007Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            int n = Convert.ToInt32(line);
            string[] aryN = new string[n];
            for (int i = 0; i < n; i++)
            {
                aryN[i] = "*";
            }
            System.Console.WriteLine(string.Join("", aryN));
        }
    }
}
