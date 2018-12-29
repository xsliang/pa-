

using System;
using System.Collections.Generic;
public class C018
{
    public static void C018Main()
    {
        
        
        try
        {
            var line = System.Console.ReadLine();
            if (Convert.ToInt32(line) >= 1 && Convert.ToInt32(line) <= 100)
            {
                int n = Convert.ToInt32(line);
                Dictionary<string, int> listA = new Dictionary<string, int>();
                for (int i = 0; i < n; i++)
                {
                    line = System.Console.ReadLine();
                    if (line.Split(' ').Length != 2)
                    {
                        return;
                    }
                    else
                    {
                        string a = line.Split(' ')[0];
                        int b = Convert.ToInt32(line.Split(' ')[1]);
                        if (a.Length < 1 && a.Length > 10)
                        {
                            return;
                        }
                        if (b < 1 && b > 100)
                        {
                            return;
                        }
                        listA.Add(a, b);
                    }
                }
                Dictionary<string, int> listB = new Dictionary<string, int>();
                line = System.Console.ReadLine();
                if (Convert.ToInt32(line) >= 0 && Convert.ToInt32(line) <= 100)
                {
                    int m = Convert.ToInt32(line);
                    for (int i = 0; i < m; i++)
                    {
                        line = System.Console.ReadLine();
                        if (line.Split(' ').Length != 2)
                        {
                            return;
                        }
                        else
                        {
                            string a = line.Split(' ')[0];
                            int b = Convert.ToInt32(line.Split(' ')[1]);
                            if (a.Length < 1 && a.Length > 10)
                            {
                                return;
                            }
                            if (b < 1 && b > 10000)
                            {
                                return;
                            }
                            listB.Add(a, b);
                        }
                    }
                }
                List<int> listC = new List<int>();
                foreach (var item in listA)
                {
                    if (listB.ContainsKey(item.Key) == false)
                    {
                        System.Console.WriteLine(0);
                        return;
                    }
                    else
                    {
                        int valueA = item.Value;
                        int valueB = listB[item.Key];
                        listC.Add(valueB / valueA);
                    }
                }
                if (listB.Count > 0)
                {
                    listC.Sort();
                    System.Console.WriteLine(listC[0]);
                }
                else
                {
                    System.Console.WriteLine(0);
                }
            }
        }
        catch
        {

        }
    }
}

