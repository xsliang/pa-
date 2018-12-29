


using System;
public class D048
{
    public static void D048Main()
    {
        
        
        try
        {
            int[] a = new int[5];
            for (int i = 0; i < 5; i++)
            {
                var line = System.Console.ReadLine();
                if (Convert.ToInt32(line)<1 || Convert.ToInt32(line) > 31)
                {
                    return;
                }
                if (i > 0)
                {
                    if (a[i - 1] < Convert.ToInt32(line))
                    {
                        a[i] = Convert.ToInt32(line);
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    a[i] = Convert.ToInt32(line);
                }

            }

            for (int i = 0; i < 4; i++)
            {
                int result = a[i + 1] - a[i];
                System.Console.WriteLine(result.ToString());
            }

        }
        catch
        { }
    }
}