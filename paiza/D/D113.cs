using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D113
    {
        public static void D113Main()
        {
            try
            {
                var line1 = System.Console.ReadLine();
                int h = Convert.ToInt32(line1.Split(':')[0]);
                int m = Convert.ToInt32(line1.Split(':')[1]);
                if (h >= 0 && h <= 12 && m >= 0 && m <= 59)
                {
                    h = h - 8;
                    if (h < 0)
                    {
                        h = 24 + h;
                    }

                    System.Console.WriteLine(h + ":" + m);
                }
            }
            catch
            {
            }
        }
    }
}
