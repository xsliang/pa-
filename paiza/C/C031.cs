
using System;
using System.Collections.Generic;

namespace paiza.C
{
    class C031
    {
        public static void C031Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N < 1 || N > 100)
                {
                    return;
                }
                Dictionary<string, int> data = new Dictionary<string, int>();
                for (int i = 0; i < N; i++)
                {
                    line = System.Console.ReadLine();
                    string p = line.Split(' ')[0];
                    int s = Convert.ToInt32(line.Split(' ')[1]);
                    if (p.Length < 1 || p.Length > 20 || -12 > s || s > 14)
                    {
                        return;
                    }
                    data.Add(p, s);
                }
                line = System.Console.ReadLine();
                string q = line.Split(' ')[0];
                string t = line.Split(' ')[1];
                int sa = data[q];

                foreach (var item in data)
                {

                    int hour = Convert.ToInt32(t.Split(':')[0]) + (item.Value - sa);
                    if (hour < 0)
                    {
                        hour = 24 + hour;
                    }
                    if (hour >= 24)
                    {
                        hour = hour - 24;
                    }

                    System.Console.WriteLine(hour.ToString("0#") + ":" + t.Split(':')[1]);
                }
            }
            catch
            {
            }

        }
    }
}
