

public class D047
{
    public static void D047Main()
    {
        
        
        var line1 = System.Console.ReadLine();
        var line2 = System.Console.ReadLine();
        var line3 = System.Console.ReadLine();
        if (line1.ToString().Length >= 1 && line1.ToString().Length <= 20 &&
        line2.ToString().Length >= 1 && line2.ToString().Length <= 20 &&
        line3.ToString().Length >= 1 && line3.ToString().Length <= 20)
        {
            System.Console.WriteLine("Gold " + line1.ToString());
            System.Console.WriteLine("Silver " + line2.ToString());
            System.Console.WriteLine("Bronze " + line3.ToString());
        }
    }
}