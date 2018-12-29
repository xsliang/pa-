

using System;
public class D045
{
    public static void D045Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 5)
        {
            switch (Convert.ToInt32(line))
            {
                case 5:
                    System.Console.WriteLine("A");
                    break;
                case 4:
                    System.Console.WriteLine("B");
                    break;
                case 3:
                    System.Console.WriteLine("C");
                    break;
                case 2:
                    System.Console.WriteLine("D");
                    break;
                case 1:
                    System.Console.WriteLine("E");
                    break;
                default:
                    break;
            }
        }
    }
}
