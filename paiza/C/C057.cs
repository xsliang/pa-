using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C057
    {
        public static void C057Main()
        {
            var line = System.Console.ReadLine();
            if (line.Split(' ').Length == 3)
            {
                int T = Convert.ToInt32(line.Split(' ')[0]);
                int x = Convert.ToInt32(line.Split(' ')[1]);
                int y = Convert.ToInt32(line.Split(' ')[2]);

                int count = 0;
                bool ok = false;

                if (T >= 1 && T <= 100 && x >= -1000 && x <= 1000 && y >= 1 && y <= 1000)
                {

                    int maxX = x;
                    for (int i = 0; i < T; i++)
                    {
                        line = System.Console.ReadLine();

                        if (line.Split(' ').Length == 2)
                        {
                            int a = Convert.ToInt32(line.Split(' ')[0]);
                            int b = Convert.ToInt32(line.Split(' ')[1]);

                            if (a >= -1000 && a <= 1000 && b >= -1000 && b <= 1000)
                            {
                                if (ok == true)
                                {
                                    continue;
                                }
                                else
                                {
                                    x = x + a;

                                    y = y + b;

                                    count++;

                                    if (y <= 0)
                                    {
                                        ok = true;
                                    }
                                    else
                                    {
                                        if (maxX < x)
                                        {
                                            maxX = x;
                                        }
                                    }
                                }
                            }


                        }
                    }
                    System.Console.WriteLine(maxX);
                }


            }
        }
    }
}
