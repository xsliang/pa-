
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C028
    {
        public static void C028Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N < 1 || N > 1000)
                {
                    return;
                }
                int count = 0;
                for (int i = 0; i < N; i++)
                {
                    line = System.Console.ReadLine();
                    string q = line.Split(' ')[0];
                    string a = line.Split(' ')[1];
                    if (q.Length < 1 || q.Length > 20 || a.Length < 1 || a.Length > 20)
                    {
                        return;
                    }
                    if (q.Length != a.Length)
                    {
                        continue;
                    }
                    else
                    {
                        if (q == a)
                        {
                            count = count + 2;
                        }
                        else
                        {
                            int temp = 0;
                            for (int j = 0; j < q.Length; j++)
                            {
                                if (q[j] != a[j])
                                {
                                    temp++;
                                }
                            }
                            if (temp == 1)
                            {
                                count++;
                            }
                        }
                    }
                }
                System.Console.WriteLine(count);

            }
            catch
            {
            }
        }
    }
}
