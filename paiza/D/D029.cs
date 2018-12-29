

using System;
public class D029
{
    public static void D029Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 6)
        {
            int n = Convert.ToInt32(line);
            switch (n)
            {
                case 1:
                    n = 6;
                    break;
                case 2:
                    n = 5;
                    break;
                case 3:
                    n = 4;
                    break;
                case 4:
                    n = 3;
                    break;
                case 5:
                    n = 2;
                    break;
                case 6:
                    n = 1;
                    break;
                default:
                    break;
            }
            System.Console.WriteLine(n);
        }

    }
}
