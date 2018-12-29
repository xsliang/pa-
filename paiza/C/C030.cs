
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C030
    {
        public static void C030Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int H = Convert.ToInt32(line.Split(' ')[0]);
                int W = Convert.ToInt32(line.Split(' ')[1]);
                if (H < 1 || H > 400 || W < 1 || W > 400)
                {
                    return;
                }

                List<string> result = new List<string>();

                for (int i = 0; i < H; i++)
                {
                    var dataLine = System.Console.ReadLine();

                    string[] aryLine = dataLine.Split(' ');

                    string[] aryResult = new string[W];

                    for (int j = 0; j < W; j++)
                    {
                        int intNum = Convert.ToInt32(aryLine[j]);
                        if (intNum < 0 || intNum > 255)
                        {
                            return;
                        }

                        if (intNum >= 128)
                        {
                            aryResult[j] = "1";
                        }
                        else if (intNum <= 127)
                        {
                            aryResult[j] = "0";
                        }
                    }

                    result.Add(string.Join(" ", aryResult));
                }

                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            catch
            {

            }
        }
    }
}
