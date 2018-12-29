

using System;
public class D019
{
    public static void D019Main()
    {
        var line = System.Console.ReadLine();
        if (line.Split(' ')[0].Length >= 1 && line.Split(' ')[0].Length <= 10 &&
        Convert.ToInt32(line.Split(' ')[1]) >= 1 && Convert.ToInt32(line.Split(' ')[1]) <= line.Split(' ')[0].Length)
        {
            int n = Convert.ToInt32(line.Split(' ')[1]);
            string s = line.Split(' ')[0];
            System.Console.WriteLine(s.Substring(n - 1, 1));
        }
    }
}
