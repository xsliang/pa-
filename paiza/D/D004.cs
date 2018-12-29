
using System;
public class D004
{
    public static void D004Main()
    {
        try
        {
            var n = System.Console.ReadLine();
            if (Convert.ToInt32(n) >= 1 && Convert.ToInt32(n) <= 20)
            {
                int number = Convert.ToInt32(n);
                string[] aryN = new string[number];
                for (int i = 0; i < number; i++)
                {
                    aryN[i] = System.Console.ReadLine();
                }
                System.Console.WriteLine("Hello " + string.Join(",", aryN) + ".");
            }
        }
        catch
        {

        }

    }
}

