// D002: comparison of the number of

//The positive integers a and b are entered separated by spaces.

//compare a and b, please print the value whichever is greater.find out the "eq" and if a and b are the same.

using System;
public class D002
{
    public static void Main()
    {
        try
        {
            var line = System.Console.ReadLine();
            if (line.ToString().Split(' ').Length == 2)
            {
                int a = Convert.ToInt32(line.ToString().Split(' ')[0]);
                int b = Convert.ToInt32(line.ToString().Split(' ')[1]);
                if (a >= 0 && a <= 1000 && b >= 0 && b <= 1000)
                {
                    if (a > b)
                    {
                        System.Console.WriteLine(a.ToString());
                    }
                    else if (a < b)
                    {
                        System.Console.WriteLine(b.ToString());
                    }
                    else
                    {
                        System.Console.WriteLine("eq");
                    }
                }
            }
        }
        catch
        {

        }
    }
}


