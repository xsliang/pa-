
using System;
using System.Collections.Generic;

public class C006
{
    public static void C006Main()
    {
        try
        {
            var line1 = System.Console.ReadLine();
            if (1 <= Convert.ToInt32(line1.Split(' ')[0]) && Convert.ToInt32(line1.Split(' ')[0]) <= 100 &&
            1 <= Convert.ToInt32(line1.Split(' ')[1]) && Convert.ToInt32(line1.Split(' ')[1]) <= 1000 &&
            1 <= Convert.ToInt32(line1.Split(' ')[2]) && Convert.ToInt32(line1.Split(' ')[2]) <= Convert.ToInt32(line1.Split(' ')[1]))
            {
                int N = Convert.ToInt32(line1.Split(' ')[0]);
                int M = Convert.ToInt32(line1.Split(' ')[1]);
                int K = Convert.ToInt32(line1.Split(' ')[2]);
                var line2 = System.Console.ReadLine();
                if (line2.Split(' ').Length != N)
                {
                    return;
                }
                List<double> C = new List<double>();
                for (int i = 0; i < line2.Split(' ').Length; i++)
                {
                    if (Convert.ToDouble(line2.Split(' ')[i]) >= 0 && Convert.ToDouble(line2.Split(' ')[i]) <= 100)
                    {
                        C.Add(Convert.ToDouble(line2.Split(' ')[i]));
                    }
                    else
                    {
                        return;
                    }
                }
                List<string> listX = new List<string>();
                for (int i = 0; i < M; i++)
                {
                    var lineX = System.Console.ReadLine();
                    if (lineX.Split(' ').Length != N)
                    {
                        return;
                    }
                    for (int j = 0; j < N; j++)
                    {
                        if (Convert.ToInt32(lineX.Split(' ')[j]) >= 0 && Convert.ToInt32(lineX.Split(' ')[j]) <= 100000)
                        {

                        }
                        else
                        {
                            return;
                        }
                    }
                    listX.Add(lineX);
                }
                List<int> result = new List<int>();
                for (int i = 0; i < listX.Count; i++)
                {
                    string temp1 = listX[i];
                    double temp2 = 0;
                    for (int j = 0; j < N; j++)
                    {
                        temp2 = temp2 + Convert.ToDouble(temp1.Split(' ')[j]) * C[j];
                    }     
                    result.Add(Convert.ToInt32(Math.Round(temp2, MidpointRounding.AwayFromZero)));
                }
                result.Sort();

                for (int i = 0; i < K; i++)
                {
                    System.Console.WriteLine(result[result.Count - i - 1]);
                }
            }
        }
        catch
        {

        }

    }
}
