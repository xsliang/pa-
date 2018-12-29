

using System;
public class D009
{
    public static void D009Main()
    {
        try
        {
            var a = System.Console.ReadLine();
            string[] number = a.Split(' ');
            if (Convert.ToInt32(number[0]) >= 1 && Convert.ToInt32(number[0]) <= 2014 &&
            Convert.ToInt32(number[1]) >= 1 && Convert.ToInt32(number[1]) <= 2014)
            {
                int Na = Convert.ToInt32(number[0]);
                int Nb = Convert.ToInt32(number[1]);
                if (Na < Nb)
                {
                    System.Console.WriteLine(Convert.ToString(Nb - Na));
                }
            }

        }
        catch { }
    }
}
