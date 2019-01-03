using System;
using System.Collections.Generic;
using System.Linq;

public class Hello
{
    private static int black = 0;
    private static int white = 0;

    public static void A003()
    {
        try
        {
            var line = System.Console.ReadLine();
            string[,] result = new string[8, 8];

            int count = Convert.ToInt32(line);

            result[3, 3] = "W";
            result[4, 3] = "B";
            result[3, 4] = "B";
            result[4, 4] = "W";

            for (int i = 0; i < count; i++)
            {
                line = System.Console.ReadLine();
                string[] input = line.Split(' ');
                string color = input[0];
                int x = Convert.ToInt32(input[2]) - 1;
                int y = Convert.ToInt32(input[1]) - 1;
                result[x, y] = color;
                string other;
                if (color == "B")
                {
                    other = "W";
                }
                else
                {
                    other = "B";
                }
                NewMethod1(result, color, other, y, x);

                for (int l = 0; l < 8; l++)
                {
                    for (int m = 0; m < 8; m++)
                    {
                        if (result[l, m] == "B")
                        {
                            black++;
                            Console.Write("●");
                        }
                        else if (result[l, m] == "W")
                        {
                            white++;
                            Console.Write("〇");
                        }
                        else
                        {
                            Console.Write("□");
                        }
                    }
                    Console.WriteLine("\r\n");
                }
                if (black == 0 || white == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\r\n");
                    Console.WriteLine("\r\n");
                    black = 0;
                    white = 0;
                }

            }
            black = 0;
            white = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (result[i, j] == "B")
                    {
                        black++;
                    }
                    else if (result[i, j] == "W")
                    {
                        white++;
                    }
                }
            }

            if (black > white)
            {
                System.Console.WriteLine("{0}-{1} The black won!", black.ToString().PadLeft(2, '0'), white.ToString().PadLeft(2, '0'));
            }
            else if (black < white)
            {
                System.Console.WriteLine("{0}-{1} The white won!", black.ToString().PadLeft(2, '0'), white.ToString().PadLeft(2, '0'));
            }
            else
            {
                System.Console.WriteLine("{0}-{1} Draw!", black.ToString().PadLeft(2, '0'), white.ToString().PadLeft(2, '0'));
            }
        }
        catch
        {

        }

    }

    private static bool NewMethod(string[,] result, int x, int y, string me, string other, string type)
    {
        int currentX = 0;
        int currentY = 0;

        if (type == "1")
        {
            currentX = x + 1;
            currentY = y;
        }
        else if (type == "2")
        {
            currentX = x - 1;
            currentY = y;
        }
        else if (type == "3")
        {
            currentY = y + 1;
            currentX = x;

        }
        else if (type == "4")
        {
            currentY = y - 1;
            currentX = x;
        }
        else if (type == "5")
        {
            currentY = y + 1;
            currentX = x + 1;
        }
        else if (type == "6")
        {
            currentY = y - 1;
            currentX = x + 1;
        }
        else if (type == "7")
        {
            currentY = y + 1;
            currentX = x - 1;
        }
        else if (type == "8")
        {
            currentY = y - 1;
            currentX = x - 1;
        }

        if (currentX <= 7 && currentX >= 0 && currentY <= 7 && currentY >= 0 && result[currentX, currentY] != null)
        {
            if (result[currentX, currentY] == me)
            {
                return true;
            }
            else if (result[currentX, currentY] == other)
            {
                if (NewMethod(result, currentX, currentY, me, other, type) == true)
                {
                    result[currentX, currentY] = me;
                    //NewMethod1(result, me, other, currentY, currentX);
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        else
        {
            return false;
        }

        return false;

    }

    private static void NewMethod1(string[,] result, string me, string other, int currentY, int currentX)
    {
        //check x+
        NewMethod(result, currentX, currentY, me, other, "1");
        //check x-   
        NewMethod(result, currentX, currentY, me, other, "2");
        //check y+
        NewMethod(result, currentX, currentY, me, other, "3");
        //check y- 
        NewMethod(result, currentX, currentY, me, other, "4");
        //check x+ y+
        NewMethod(result, currentX, currentY, me, other, "5");
        //check x+ y-
        NewMethod(result, currentX, currentY, me, other, "6");
        //check x- y+
        NewMethod(result, currentX, currentY, me, other, "7");
        //check x- y-
        NewMethod(result, currentX, currentY, me, other, "8");
    }
}

