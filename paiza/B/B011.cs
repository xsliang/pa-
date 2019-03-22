using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.B
{
    class B011
    {
        public static void B011Main()
        {
            try
            {
                var line1 = System.Console.ReadLine();

                int n = Convert.ToInt32(line1.Split(' ')[0]);
                int m = Convert.ToInt32(line1.Split(' ')[1]);

                if (m >= 1 && m <= 100000 && n >= 1 && n <= 100000)
                {
                    int paper = m / n;
                    int seat = m % n;
                    if (seat > 0)
                    {
                        paper = paper + 1;
                    }

                    // left or right
                    //left
                    if (paper % 2 == 1)
                    {
                        if (seat == 0)
                        {
                            seat = n;
                        }

                        Console.WriteLine(m + (n - seat) + (n - (seat - 1)));
                    }
                    //right
                    else if (paper % 2 == 0)
                    {
                        if (seat == 0)
                        {
                            seat = n;
                        }

                        Console.WriteLine(m - (seat) - ((seat - 1)));
                    }
                }
            }
            catch
            {
            }

        }
    }
}
