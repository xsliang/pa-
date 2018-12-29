

public class D036
{
    public static void D036Main()
    {
        
        
        var line = System.Console.ReadLine();
        if (line.Length >= 1 && line.Length <= 100)
        {
            line = line.Replace("at", "@");
            System.Console.WriteLine(line);
        }
    }
}