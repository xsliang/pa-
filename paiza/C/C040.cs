
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C040
    {
        static void C040Main()
        {
            var line = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N < 2 || N > 100)
            {
                return;
            }

            decimal ge = 0;
            decimal le = 0;

            for (int i = 0; i < N; i++)
            {
                line = System.Console.ReadLine();
                string c = line.Split(' ')[0];
                decimal temp = Convert.ToDecimal(line.Split(' ')[1]);

                if (temp < 100 || temp > 200)
                {
                    return;
                }

                if (c == "ge")
                {
                    if (ge == 0)
                    {
                        ge = temp;
                    }
                    else if (ge < temp)
                    {
                        ge = temp;
                    }
                }
                else if (c == "le")
                {
                    if (le == 0)
                    {
                        le = temp;
                    }
                    else if (le > temp)
                    {
                        le = temp;
                    }
                }
                else
                {
                    return;
                }
            }

            Console.WriteLine(ge + " " + le);
        }
    }
}
