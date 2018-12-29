

public class D010
{
    public static void D010Main()
    {
        var s = System.Console.ReadLine();
        var t = System.Console.ReadLine();
        if (s.Length >= 1 && s.Length <= 64 && t.Length >= 1 && t.Length <= 64)
        {
            string test = "1234567890.abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char item in s)
            {
                if (test.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            foreach (char item in t)
            {
                if (test.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            System.Console.WriteLine(s + "@" + t);
        }
    }
}
