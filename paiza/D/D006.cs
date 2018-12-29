using System;
public class D006
{
    public static void D006Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line.Split(' ')[0]) >= 1 && Convert.ToInt32(line.Split(' ')[0]) <= 1000)
        {
            int n = Convert.ToInt32(line.Split(' ')[0]);
            string unit = line.Split(' ')[1];
            switch (unit)
            {
                case "km":
                    System.Console.WriteLine(n + "000000");
                    break;
                case "m":
                    System.Console.WriteLine(n + "000");
                    break;
                case "cm":
                    System.Console.WriteLine(n + "0");
                    break;
            }
        }
    }
}
