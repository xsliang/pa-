

public class D011
{
    public static void D011Main()
    {
        var line = System.Console.ReadLine();
        string test = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (line.Length == 1 && test.Contains(line) == true)
        {
            System.Console.WriteLine(test.IndexOf(line) + 1);
        }
    }
}
