using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C041
    {
        static void C041Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                int N = Convert.ToInt32(line);

                if (N >= 1 && N <= 100)
                {
                    List<rsult> lstResult = new List<rsult>();

                    for (int i = 0; i < N; i++)
                    {
                        line = System.Console.ReadLine();
                        int g = Convert.ToInt32(line.Split(' ')[0]);
                        int s = Convert.ToInt32(line.Split(' ')[1]);
                        int b = Convert.ToInt32(line.Split(' ')[2]);

                        if (g >= 1 && g <= 100 && s >= 1 && s <= 100 && b >= 1 && b <= 100)
                        {
                            lstResult.Add(new rsult { g = g, s = s, b = b });
                        }
                    }

                    lstResult = lstResult.OrderByDescending(x => x.b).OrderByDescending(x => x.s).OrderByDescending(x => x.g).ToList();

                    foreach (var item in lstResult)
                    {
                        Console.WriteLine(item.g + " " + item.s + " " + item.b);
                    }
                }
            }
            catch
            {
            }
        }
    }

    public class rsult
    {
        public int g { get; set; }

        public int s { get; set; }

        public int b { get; set; }
    }
}
