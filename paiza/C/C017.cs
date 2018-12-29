
using System;
public class C017
{
    public static void C017Main()
    {
        
        
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line.Split(' ')[0]) >= 1 && Convert.ToInt32(line.Split(' ')[0]) <= 10 &&
        Convert.ToInt32(line.Split(' ')[1]) >= 1 && Convert.ToInt32(line.Split(' ')[1]) <= 4)
        {
            var line1 = System.Console.ReadLine();
            int a = Convert.ToInt32(line.Split(' ')[0]);
            int b = Convert.ToInt32(line.Split(' ')[1]);
            if (Convert.ToInt32(line1) >= 1 && Convert.ToInt32(line1) <= 40)
            {
                int n = Convert.ToInt32(line1);
                for (int i = 0; i < n; i++)
                {
                    var line2 = System.Console.ReadLine();
                    if (Convert.ToInt32(line2.Split(' ')[0]) >= 1 && Convert.ToInt32(line2.Split(' ')[0]) <= 10 &&
                    Convert.ToInt32(line2.Split(' ')[1]) >= 1 && Convert.ToInt32(line2.Split(' ')[1]) <= 4)
                    {
                        int A = Convert.ToInt32(line2.Split(' ')[0]);
                        int B = Convert.ToInt32(line2.Split(' ')[1]);
                        if (a > A)
                        {
                            System.Console.WriteLine("High");
                        }
                        else if (a < A)
                        {
                            System.Console.WriteLine("Low");
                        }
                        else
                        {
                            if (b < B)
                            {
                                System.Console.WriteLine("High");
                            }
                            else
                            {
                                System.Console.WriteLine("Low");
                            }
                        }
                    }
                }
            }
        }

    }
}
