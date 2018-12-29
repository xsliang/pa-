

public class D044
{
    public static void D044Main()
    {
        
        
        var line = System.Console.ReadLine();
        try
        {
            string s1 = line.ToString().Split(' ')[0];
            string s2 = line.ToString().Split(' ')[1];
            if (s1.Length >= 1 && s1.Length <= 100 &&
            s2 == "M" || s2 == "F")
            {
                if (s2 == "M")
                {
                    System.Console.WriteLine("Hi, Mr. " + s1);
                }
                else
                {
                    System.Console.WriteLine("Hi, Ms. " + s1);
                }
            }
        }
        catch
        {

        }
    }
}
