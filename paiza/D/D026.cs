
public class D026
{
    public static void D026Main()
    {
        int count = 0;
        for (int i = 0; i < 7; i++)
        {
            var line = System.Console.ReadLine();
            if (line == "yes" || line == "no")
            {
                if (line == "no")
                {
                    count++;
                }
            }
            else
            {
                return;
            }
        }
        System.Console.WriteLine(count);
    }
}
