using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C060
    {
        public static void C060Main()
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line.Split(' ')[0]);
            int K = Convert.ToInt32(line.Split(' ')[1]);
            int P = Convert.ToInt32(line.Split(' ')[2]);

            if (N >= 3 && N <= 1000 && K >= 1 && K <= N && P >= 1 && P <= N)
            {
                line = System.Console.ReadLine();
                string[] words = line.Split(' ');
                List<string> lstWord = new List<string>();
                foreach (var item in words)
                {
                    if (lstWord.Contains(item) || item.Length > 10)
                    {
                        return;
                    }
                    else
                    {
                        lstWord.Add(item);
                    }
                }

                lstWord.Sort();

                words = lstWord.ToArray();

                int first = (P - 1) * K;
                for (int i = 0; i < K; i++)
                {
                    if (first + i >= N)
                    {
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(words[first + i]);
                    }
                }
            }
        }
    }
}

