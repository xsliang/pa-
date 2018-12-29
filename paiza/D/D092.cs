using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D092
    {
        public static void D092Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();

                decimal x1 = Convert.ToDecimal(line.Split(' ')[0]);
                decimal y1 = Convert.ToDecimal(line.Split(' ')[1]);
                decimal z1 = Convert.ToDecimal(line.Split(' ')[2]);

                decimal x2 = Convert.ToDecimal(line2.Split(' ')[0]);
                decimal y2 = Convert.ToDecimal(line2.Split(' ')[1]);
                decimal z2 = Convert.ToDecimal(line2.Split(' ')[2]);

                if (x1 >= 1 && x1 <= 30 && x2 >= 1 && x2 <= 30 && y1 >= 1 && y1 <= 30 && y2 >= 1 && y2 <= 30 &&
                    z1 >= 1000 && z1 <= 50000 && z2 >= 1000 && z2 <= 50000)
                {
                    if (z1 / (x1 * y1) < z2 / (x2 * y2))
                    {
                        System.Console.WriteLine(line);
                    }
                    else if (z1 / (x1 * y1) > z2 / (x2 * y2))
                    {
                        System.Console.WriteLine(line2);
                    }
                    else
                    {
                        System.Console.WriteLine("DRAW");
                    }
                }


            }
            catch
            {
            }


        }
    }
}
