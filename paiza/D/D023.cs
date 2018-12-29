

public class D023
{
    public static void D023Main()
    {
        var line = System.Console.ReadLine();
        int count = 0;
        if (line.Length >= 1 && line.Length <= 100)
        {
            string test = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char item in line)
            {
                if (test.Contains(item.ToString()) == false)
                {
                    return;
                }
                if (item == 'A')
                {
                    count++;
                }
            }
            System.Console.WriteLine(count);
        }
    }
}
