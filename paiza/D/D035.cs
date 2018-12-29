

using System;
public class D035
{
    public static void D035Main()
    {
        try
        {
            var line = System.Console.ReadLine();
            if (line.Split(' ').Length == 3)
            {
                string year = line.Split(' ')[0];
                string month = line.Split(' ')[1];
                string day = line.Split(' ')[2];
                if (Convert.ToInt32(year) >= 2000 && Convert.ToInt32(year) <= 2016 &&
                Convert.ToInt32(month) >= 1 && Convert.ToInt32(month) <= 12 &&
                Convert.ToInt32(day) >= 1 && Convert.ToInt32(day) <= 31)
                {
                    System.Console.WriteLine(year + "/" + month + "/" + day);
                }
            }

        }
        catch
        { }
    }
}
