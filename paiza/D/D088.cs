
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D088
    {
        public static void D088Main()
        {
            var line = System.Console.ReadLine();

            int t = Convert.ToInt32(line.Split(' ')[0]);
            int u = Convert.ToInt32(line.Split(' ')[1]);

            if (t < -40 || t > 40 || u < -40 || u > 40 || u >= t)
            {
                return;
            }
            else
            {
                System.Console.WriteLine(t - u);
            }
        }
    }
}
