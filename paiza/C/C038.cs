using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C038
    {
        static void C038Main(string[] args)
        {
            try
            {
                var line = System.Console.ReadLine();
                int M = Convert.ToInt32(line.Split(' ')[0]);
                int N = Convert.ToInt32(line.Split(' ')[1]);

                List<int> lest3 = new List<int>();
                Dictionary<int, int> a = new Dictionary<int, int>();
                if (M >= 2 && M <= 100 && N >= M && N <= 1000)
                {
                    for (int i = 0; i < M; i++)
                    {
                        line = System.Console.ReadLine();
                        int m = Convert.ToInt32(line);
                        lest3.Add(m);
                        if (m >= 1 && m <= N)
                        {
                            a.Add(m, N % m);
                        }
                    }

                    var list1 = a.OrderBy(x => x.Value).ToList();

                    int key = list1[0].Value;
                    var list2 = list1.Where(x => x.Value == key).ToList();

                    int max = 0;
                    for (int i = 0; i < list2.Count; i++)
                    {
                        if (list2[i].Key > max)
                        {
                            max = list2[i].Key;
                        }
                    }

                    for (int i = 0; i < lest3.Count; i++)
                    {
                        if (lest3[i] == max)
                        {
                            Console.WriteLine(i + 1);
                            break;
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
