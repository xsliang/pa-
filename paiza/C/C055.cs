using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C055
    {
        public static void C055Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N >= 1 && N <= 100)
                {
                    line = System.Console.ReadLine();
                    string G = line;
                    if (G.Length >= 1 && G.Length <= 100)
                    {
                        List<string> aa = new List<string>();
                        for (int i = 0; i < N; i++)
                        {
                            line = System.Console.ReadLine();
                            string S = line;
                            if (S.Length >= 1 && S.Length <= 100)
                            {
                                if (S.Contains(G))
                                {
                                    aa.Add(S);
                                }
                            }
                        }

                        if (aa.Count == 0)
                        {
                            System.Console.WriteLine("None");
                        }
                        else
                        {
                            foreach (var item in aa)
                            {
                                System.Console.WriteLine(item);
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}
