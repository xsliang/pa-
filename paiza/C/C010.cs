

using System;
public class C010
{
    public static void C010Main()
    {
        try
        {
            
            
            var abR = System.Console.ReadLine();
            if (Convert.ToInt32(abR.Split(' ')[0]) >= 0 && Convert.ToInt32(abR.Split(' ')[0]) <= 100 &&
            Convert.ToInt32(abR.Split(' ')[1]) >= 0 && Convert.ToInt32(abR.Split(' ')[1]) <= 100 &&
            Convert.ToInt32(abR.Split(' ')[2]) >= 1 && Convert.ToInt32(abR.Split(' ')[2]) <= 100)
            {
                int a = Convert.ToInt32(abR.Split(' ')[0]);
                int b = Convert.ToInt32(abR.Split(' ')[1]);
                int R = Convert.ToInt32(abR.Split(' ')[2]);

                var lineN = System.Console.ReadLine();
                if (Convert.ToInt32(lineN) >= 1 && Convert.ToInt32(lineN) <= 1000)
                {
                    int N = Convert.ToInt32(lineN);
                    for (int i = 0; i <= N; i++)
                    {
                        var lineXY = System.Console.ReadLine();
                        if (Convert.ToInt32(lineXY.Split(' ')[0]) >= 0 && Convert.ToInt32(lineXY.Split(' ')[0]) <= 100 &&
                        Convert.ToInt32(lineXY.Split(' ')[1]) >= 0 && Convert.ToInt32(lineXY.Split(' ')[1]) <= 100)
                        {
                            int x = Convert.ToInt32(lineXY.Split(' ')[0]);
                            int y = Convert.ToInt32(lineXY.Split(' ')[1]);
                            if ((x - a) * (x - a) + (y - b) * (y - b) >= R * R)
                            {
                                System.Console.WriteLine("silent");
                            }
                            else
                            {
                                System.Console.WriteLine("noisy");
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                }
            }
        }
        catch
        {

        }
    }
}
