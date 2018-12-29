
public class C016
{
    public static void C016Main()
    {
        
        
        var line = System.Console.ReadLine();
        string test = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        if (line.Length >= 1 && line.Length <= 100)
        {
            foreach (char item in line)
            {
                if (test.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            line = line.Replace("A", "4");
            line = line.Replace("E", "3");
            line = line.Replace("G", "6");
            line = line.Replace("I", "1");
            line = line.Replace("O", "0");
            line = line.Replace("S", "5");
            line = line.Replace("Z", "2");
            System.Console.WriteLine(line);
        }
    }
}

