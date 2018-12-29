
using System;
using System.Collections.Generic;
public class B012
{
    public static void B012Main()
    {
        var lineCount = System.Console.ReadLine();
        string number = "0123456789";
        List<string> lstData = new List<string>();
        List<int> resultData = new List<int>();
        try
        {
            if (Convert.ToInt32(lineCount) >= 1 && Convert.ToInt32(lineCount) <= 100)
            {
                //input
                int count = Convert.ToInt32(lineCount);
                for (int i = 0; i < count; i++)
                {
                    var dataInput = System.Console.ReadLine();
                    string data = dataInput.ToString();
                    if (data.Length != 16 && data[15] != 'X')
                    {
                        return;
                    }
                    else
                    {
                        for (int j = 0; j < 15; j++)
                        {
                            if (number.Contains(data[j].ToString()) == false)
                            {
                                return;
                            }
                        }

                        lstData.Add(data);
                    }
                }

                //compute
                for (int i = 0; i < count; i++)
                {
                    string data = lstData[i];
                    //even
                    int even = 0;
                    for (int a = 0; a < 15; a = a + 2)
                    {
                        int temp1 = Convert.ToInt32(data[a].ToString()) * 2;
                        if (temp1 < 10)
                        {
                            even = even + temp1;
                        }
                        else
                        {
                            even = even + 1 + (temp1 - 10);
                        }
                    }

                    //odd
                    int odd = 0;
                    for (int a = 1; a < 15; a = a + 2)
                    {
                        int temp1 = Convert.ToInt32(data[a].ToString());
                        odd = odd + temp1;
                    }

                    int addresult = even + odd;
                    for (int b = 0; b < 10; b++)
                    {
                        if ((addresult + b) % 10 == 0)
                        {
                            resultData.Add(b);
                            break;
                        }
                    }

                }

                //result
                for (int i = 0; i < count; i++)
                {
                    System.Console.WriteLine(resultData[i].ToString());
                }
            }
        }
        catch
        {

        }
    }
}