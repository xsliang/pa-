

using System;
public class C015
{
    public static void C015Main()
    {
        
        
        try
        {
            var lineN = System.Console.ReadLine();
            if (Convert.ToInt32(lineN) >= 1 && Convert.ToInt32(lineN) <= 1000)
            {
                int N = Convert.ToInt32(lineN);
                int Count = 0;
                for (int i = 1; i <= N; i++)
                {
                    var lineData = System.Console.ReadLine();
                    if (Convert.ToInt32(lineData.Split(' ')[0]) >= 1 && Convert.ToInt32(lineData.Split(' ')[0]) <= 31 &&
                        Convert.ToInt32(lineData.Split(' ')[1]) >= 1 && Convert.ToInt32(lineData.Split(' ')[1]) <= 10000)
                    {
                        int d = Convert.ToInt32(lineData.Split(' ')[0]);
                        int p = Convert.ToInt32(lineData.Split(' ')[1]);
                        if (d.ToString().Contains("3"))
                        {
                            Count = Count + (int)(p * 0.03);
                        }
                        else if (d.ToString().Contains("5"))
                        {
                            Count = Count + (int)(p * 0.05);
                        }
                        else
                        {
                            Count = Count + (int)(p * 0.01);
                        }
                    }
                }
                System.Console.WriteLine(Count);
            }
        }
        catch
        {
        }
    }
}