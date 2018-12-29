

using System;
using System.Collections.Generic;
public class C023
{
    public static void C023Main()
    {
        try
        {
            var line0 = System.Console.ReadLine();
            var line1 = System.Console.ReadLine();
            int n = Convert.ToInt32(line1);

            List<string> line1List = new List<string>();
            string[] aryline1 = line0.Split(' ');
            int count = aryline1.Length;

            if (1 <= n && n <= 100)
            {
                for (int i = 0; i < n; i++)
                {
                    var line2 = System.Console.ReadLine();
                    string[] line2List = line2.Split(' ');
                    if (line2List.Length == count)
                    {
                        int result = 0;
                        foreach (string item in line2List)
                        {
                            int itemNum = Convert.ToInt32(item);

                            if (1 <= itemNum && itemNum <= 100 &&
                            Array.IndexOf(aryline1, item) != -1)
                            {
                                result++;
                            }
                        }
                        line1List.Add(result.ToString());
                    }
                }
                foreach (string item in line1List)
                {
                    System.Console.WriteLine(item);
                }
            }

        }
        catch
        {


        }

    }
}
