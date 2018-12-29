

using System;
using System.Collections.Generic;
public class C005
{
    public static void C005Main()
    {
        var line = System.Console.ReadLine();
        if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
        {
            List<string> result = new List<string>();
            int m = Convert.ToInt32(line);
            for (int i = 0; i < m; i++)
            {
                var line2 = System.Console.ReadLine();
                if (line2.Split('.').Length != 4)
                {
                    result.Add("False");
                }
                else
                {
                    var temp1 = line2.Split('.');
                    if (temp1.Length < 1 || temp1.Length > 100)
                    {
                        return;
                    }
                    bool isOk = true;

                    for (int j = 0; j < 4; j++)
                    {
                        int test = 0;
                        if (int.TryParse(temp1[j], out test) == true)
                        {
                            if (Convert.ToInt32(temp1[j]) < 0 || Convert.ToInt32(temp1[j]) > 255)
                            {
                                isOk = false;
                                break;
                            }

                        }
                        else
                        {
                            isOk = false;
                            break;
                        }
                    }
                    if (isOk == true)
                    {
                        result.Add("True");
                    }
                    else
                    {
                        result.Add("False");
                    }
                }
            }
            foreach (string item in result)
            {
                System.Console.WriteLine(item);
            }
        }
    }
}
