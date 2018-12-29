

using System.Collections.Generic;
using System;
public class D017
{
    public static void D017Main()
    {
        List<int> input = new List<int>();
        for (int i = 0; i < 5; i++)
        {
            var line = System.Console.ReadLine();
            if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 99)
            {
                input.Add(Convert.ToInt32(line));
            }
            else
            {
                return;
            }

        }
        input.Sort();
        System.Console.WriteLine(input[input.Count - 1]);
        System.Console.WriteLine(input[0]);
    }
}
