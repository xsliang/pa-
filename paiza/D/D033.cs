

using System;
public class D033
{
    public static void D033Main()
    {
        var line = System.Console.ReadLine();
        var ary = line.Split(' ');
        if (ary[0].Length >= 2 && ary[0].Length <= 20 &&
        ary[1].Length >= 2 && ary[1].Length <= 20)
        {
            string test1 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string test2 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (char item in ary[0])
            {
                if (test1.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            if (test2.Contains(ary[0][0].ToString()) == false)
            {
                return;
            }
            foreach (char item in ary[1])
            {
                if (test1.Contains(item.ToString()) == false)
                {
                    return;
                }
            }
            if (test2.Contains(ary[1][0].ToString()) == false)
            {
                return;
            }
            System.Console.WriteLine(ary[0][0].ToString() + "." + ary[1][0].ToString());
        }
    }
}
