

public class D051
{
    public static void D051Main()
    {
        
        
        var line = System.Console.ReadLine();
        string[] aryline = line.ToString().Split(' ');
        if (aryline.Length > 0 && aryline.Length <= 10)
        {
            int count = 0;
            foreach (string item in aryline)
            {
                if (item == "W")
                {
                    count++;
                }

            }
            if (count >= 5)
            {
                System.Console.WriteLine("OK");
            }
            else
            {
                System.Console.WriteLine("NG");
            }
        }
    }
}
