
//Don't pass. I think my solution is correct.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.C
{
    class C025
    {
        public static void C025Main()
        {
            
            

            try
            {
                var line = System.Console.ReadLine();
                int M = Convert.ToInt32(line);
                if (M < 0 || M > 100)
                {
                    return;
                }
                line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N < 0 || N > 100)
                {
                    return;
                }

                double sum = 0;
                int x_temp = 0;
                double result = 0;
                for (int i = 0; i < N; i++)
                {
                    line = System.Console.ReadLine();
                    int x = Convert.ToInt32(line.Split(' ')[0]);
                    if (x > 23 || x < 1)
                    {
                        return;
                    }
                    if (x_temp == 0)
                    {
                        x_temp = x;
                    }
                    int y = Convert.ToInt32(line.Split(' ')[1]);
                    if (y > 59 || y < 1)
                    {
                        return;
                    }
                    int c = Convert.ToInt32(line.Split(' ')[2]);
                    if (x > 100 || x < 0)
                    {
                        return;
                    }

                    if (x_temp == x)
                    {
                        sum = sum + c;
                    }
                    else
                    {

                        result = result + Math.Ceiling(sum / M);
                        sum = 0;
                        sum = sum + c;
                    }


                }

                System.Console.WriteLine(Convert.ToInt32(result));
            }
            catch
            {

            }

        }

    }
}
