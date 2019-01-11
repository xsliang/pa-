using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C045
    {
        public static void C045Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int n = Convert.ToInt32(line.Split(' ')[0]);
                int s = Convert.ToInt32(line.Split(' ')[1]);
                int p = Convert.ToInt32(line.Split(' ')[2]);

                if (n >= 0 && n <= 10000 && s >= 1 && s <= 10000 && p >= 1 && p <= 10000)
                {
                    int temp = s * (p - 1);

                    if (temp > n)
                    {
                        Console.WriteLine("none");
                    }
                    else
                    {
                        List<int> templist = new List<int>();
                        for (int i = 0; i < s; i++)
                        {
                            if (temp + i + 1 > n)
                            {
                                break;
                            }
                            templist.Add(temp + i + 1);
                        }

                        Console.WriteLine(string.Join(" ", templist.ToArray()));
                    }
                }
            }
            catch
            {
            }
        }
    }
}
