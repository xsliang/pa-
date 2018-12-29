//D003: list of multiplication
//A positive integer n is entered.
//Positive integers from 1 to 9 integer n to find out the number multiplied by each separated by spaces.

//For example if n = 2.

//2 4 6 8 10 12 14 16 18

//And will be


using System;
public class D003
{
    public static void D003Main()
    {
        var line = System.Console.ReadLine();
        try
        {
            if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
            {
                int[] number = new int[9];
                int n = Convert.ToInt32(line);
                for (int i = 1; i <= 9; i++)
                {
                    number[i - 1] = n * i;
                }
                System.Console.WriteLine(String.Join(" ", number));
            }
        }
        catch
        {

        }

    }
}

