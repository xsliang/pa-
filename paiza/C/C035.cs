using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C035
    {
        public static void C035Main()
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N >= 1 && N <= 1000)
            {
                int count = 0;
                for (int i = 0; i < N; i++)
                {
                    var line2 = System.Console.ReadLine();
                    if (line2.Split(' ').Length != 6)
                    {
                        return;
                    }
                    else
                    {
                        var temp1 = line2.Split(' ');
                        string type = temp1[0];
                        int a = Convert.ToInt32(temp1[1]);
                        int b = Convert.ToInt32(temp1[2]);
                        int c = Convert.ToInt32(temp1[3]);
                        int d = Convert.ToInt32(temp1[4]);
                        int e = Convert.ToInt32(temp1[5]);

                        if (type == "s")
                        {
                            if (a + b + c + d + e >= 350 && b + c >= 160)
                            {
                                count++;
                            }
                        }
                        else if (type == "l")
                        {
                            if (a + b + c + d + e >= 350 && d + e >= 160)
                            {
                                count++;
                            }
                        }

                    }
                }

                System.Console.WriteLine(count);

            }
        }
    }
}
