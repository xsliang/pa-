

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D071
    {
        public static void D071Main()
        {
            try
            {
                var line = System.Console.ReadLine();

                string[] aryLine = line.Split(' ');
                int t = Convert.ToInt32(aryLine[0]);
                int m = Convert.ToInt32(aryLine[1]);
                if (t >= 0 && m >= 0 && t <= 40 && m <= 100)
                {
                    if (t >= 25 || m <= 40)
                    {
                        if (t >= 25 && m <= 40)
                        {
                            System.Console.WriteLine("No");
                        }
                        else
                        {
                            System.Console.WriteLine("Yes");
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No");
                    }

                }



            }
            catch
            {
            }
        }
    }
}
