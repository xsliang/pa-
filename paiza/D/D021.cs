

using System;
public class D021
{
    public static void D021Main()
    {
        var s = System.Console.ReadLine();
        var t = System.Console.ReadLine();
        if (s.Length >= 1 && s.Length <= 10 &&
        t.Length >= 1 && t.Length <= 10)
        {
            string test = "1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char item in s)
            {
                if (test.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            foreach (char item in t)
            {
                if (test.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            if (s == t)
            {
                System.Console.WriteLine("Yes");
            }
            else
            {
                System.Console.WriteLine("No");
            }
        }

    }
}
