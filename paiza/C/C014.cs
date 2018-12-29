

using System;
public class C014
{
    public static void C014Main()
    {
        
        
        try
        {
            var lineNR = System.Console.ReadLine();
            if (Convert.ToInt32(lineNR.Split(' ')[0]) >= 1 && Convert.ToInt32(lineNR.Split(' ')[0]) <= 100 &&
            Convert.ToInt32(lineNR.Split(' ')[1]) >= 1 && Convert.ToInt32(lineNR.Split(' ')[1]) <= 100)
            {
                int n = Convert.ToInt32(lineNR.Split(' ')[0]);
                int r = Convert.ToInt32(lineNR.Split(' ')[1]);
                for (int i = 0; i < n; i++)
                {
                    var linehwd = System.Console.ReadLine();
                    if (Convert.ToInt32(linehwd.Split(' ')[0]) >= 1 && Convert.ToInt32(linehwd.Split(' ')[0]) <= 200 &&
                    Convert.ToInt32(linehwd.Split(' ')[1]) >= 1 && Convert.ToInt32(linehwd.Split(' ')[1]) <= 200 &&
                    Convert.ToInt32(linehwd.Split(' ')[2]) >= 1 && Convert.ToInt32(linehwd.Split(' ')[2]) <= 200)
                    {
                        int h = Convert.ToInt32(linehwd.Split(' ')[0]);
                        int w = Convert.ToInt32(linehwd.Split(' ')[1]);
                        int d = Convert.ToInt32(linehwd.Split(' ')[2]);
                        if (h >= r * 2 && w >= r * 2 && d >= r * 2)
                        {
                            System.Console.WriteLine(i + 1);
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        catch
        { }
    }
}