using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C053
    {
        public static void C053Main()
        {
            try
            {
                var line0 = System.Console.ReadLine();
                int N = Convert.ToInt32(line0);
                var line = System.Console.ReadLine();
                var input = line.Split(' ');

                if (input.Length!=N)
                {
                    return;
                }

                if (N >= 1 && N <= 100)
                {
                    bool haveX10 = false;

                    bool haveZero = false;

                    int max = 0;
                    int all = 0;
                    foreach (var item in input)
                    {
                        if (item == "x10" && haveX10 == true)
                        {
                            return;
                        }
                        if (item == "0" && haveZero == true)
                        {
                            return;
                        }
                        if (item== "x10" && haveX10==false)
                        {
                            haveX10 = true;
                            continue;
                        }
                        if (item == "0" && haveZero == false)
                        {
                            haveZero = true;
                            continue;
                        }

                        int input_temp = Convert.ToInt32(item);

                        if (input_temp<0 || input_temp>100)
                        {
                            return;
                        }
                        else
                        {
                            if (input_temp>max)
                            {
                                max = input_temp;
                            }
                            all = all + input_temp;
                        }
                    }

                    if (haveZero)
                    {
                        all = all - max;
                    }
                    if (haveX10)
                    {
                        all = all * 10;
                    }

                    System.Console.WriteLine(all);
                }
            }
            catch
            {
            }
        }
    }
}
