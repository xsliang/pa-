using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D112
    {
        public static void D112Main()
        {
            try
            {
                var line1 = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();
                int n = Convert.ToInt32(line1);
                int h = Convert.ToInt32(line2);
                if (n >= 1 && n <= 200 && h >= 1 && h <= 24)
                {
                    System.Console.WriteLine(n * h);
                }
            }
            catch
            {
            }
        }
    }
}
