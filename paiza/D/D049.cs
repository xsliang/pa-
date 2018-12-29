
public class D049
{
    public static void D049Main()
    {
        
        
        var line = System.Console.ReadLine();
        if (line.ToString().Length >= 1 && line.ToString().Length <= 20)
        {
            string result = line.ToString().Replace("noaki", "");
            if (line.ToString().Length - result.Length == 5 &&
            line.ToString().Substring(0, line.ToString().Length - 5) == result)
            {
                System.Console.WriteLine(result);
            }
            else
            {
                System.Console.WriteLine(line.ToString());
            }
        }
    }
}