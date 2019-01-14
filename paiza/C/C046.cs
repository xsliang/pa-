using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C046
    {
        public static void Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N >= 1 && N <= 100)
                {
                    line = System.Console.ReadLine();
                    Dictionary<string, int> result = new Dictionary<string, int>();
                    var input2 = (line.Split(' '));
                    if (input2.Length != N)
                    {
                        return;
                    }
                    foreach (var item in input2)
                    {
                        if (item.Length < 1 || item.Length > 20)
                        {
                            return;
                        }

                        result.Add(item, 0);
                    }

                    line = System.Console.ReadLine();
                    N = Convert.ToInt32(line);

                    for (int i = 0; i < N; i++)
                    {
                        line = System.Console.ReadLine();
                        string name = line.Split(' ')[0];
                        if (name.Length < 1 || name.Length > 20)
                        {
                            return;
                        }
                        int value = Convert.ToInt32(line.Split(' ')[1]);

                        if (value < 1 || value > 10000)
                        {
                            return;
                        }

                        result[name] = result[name] + value;
                    }


                    var output = result.OrderByDescending(x => x.Value).ToList();

                    foreach (var item in output)
                    {
                        System.Console.WriteLine(item.Key);
                    }
                }
            }
            catch
            {

            }
        }
    }
}
