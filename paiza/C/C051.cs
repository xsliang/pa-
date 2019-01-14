using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C051
    {
        public static void C051Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int a = Convert.ToInt32(line.Split(' ')[0]);
                int b = Convert.ToInt32(line.Split(' ')[1]);
                int c = Convert.ToInt32(line.Split(' ')[2]);
                int d = Convert.ToInt32(line.Split(' ')[3]);

                if (a>=1 && a<=9 && b >= 1 && b <= 9 && c >= 1 && c <= 9 && d >= 1 && d <= 9)
                {
                    List<int> result = new List<int>();

                    result.Add((a * 10 + b) + (c * 10 + d));
                    result.Add((a * 10 + b) + (d * 10 + c));
                    result.Add((a * 10 + c) + (b * 10 + d));
                    result.Add((a * 10 + c) + (d * 10 + b));
                    result.Add((a * 10 + d) + (b * 10 + c));
                    result.Add((a * 10 + d) + (c * 10 + b));
                    result.Add((c * 10 + a) + (b * 10 + d));

                    result.Add((c * 10 + d) + (b * 10 + a));

                    result.Add((d * 10 + b) + (c * 10 + a));
                    result.Add((d * 10 + a) + (b * 10 + c));
                    result.Add((d * 10 + a) + (c * 10 + b));
                    result.Add((d * 10 + c) + (b * 10 + a));

                    result.Sort();

                    System.Console.WriteLine(result[11]);
                }
            }
            catch
            {
            }
        }
    }
}
