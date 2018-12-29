

using System;
public class D065
{
    public static void D065Main()
    {
        var line = System.Console.ReadLine();
        try
        {
            if (line.Length == 3)
            {
                int number = Convert.ToInt32(line.Substring(0, 1));
                if (number == 2)
                {
                    System.Console.WriteLine("ok");
                }
                else if (number == 4)
                {
                    System.Console.WriteLine("error");
                }
                else
                {
                    System.Console.WriteLine("unknown");
                }

            }
        }
        catch
        {
        }
    }

}
