

using System;
using System.Collections.Generic;
public class C013
{
    public static void C013Main()
    {
        
        
        try
        {
            var line1 = System.Console.ReadLine();
            if (Convert.ToInt32(line1) >= 0 && Convert.ToInt32(line1) <= 9)
            {
                int m = Convert.ToInt32(line1);
                var line2 = System.Console.ReadLine();
                if (Convert.ToInt32(line2) >= 1 && Convert.ToInt32(line1) <= 100)
                {
                    int n = Convert.ToInt32(line2);
                    List<string> r = new List<string>();
                    for (int i = 0; i < n; i++)
                    {
                        var line3 = System.Console.ReadLine();
                        if (Convert.ToInt32(line3) >= 1 && Convert.ToInt32(line3) <= 1000)
                        {
                            if (line3.ToString().Contains(m.ToString()))
                            {

                            }
                            else
                            {
                                r.Add(line3);
                            }
                        }
                    }
                    if (r.Count == 0)
                    {
                        System.Console.WriteLine("none");
                    }
                    else
                    {
                        foreach (string temp in r)
                        {
                            System.Console.WriteLine(temp);
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
