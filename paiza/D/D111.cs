using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D111
    {
        public static void D111Main()
        {
            try
            {
                var line1 = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();
                int n = Convert.ToInt32(line1);
                if (n >= 1 && n <= 100 && line2.Length >= n && line2.Length <= 100)
                {
                    System.Console.WriteLine(line2.Substring(0, n));
                }
            }
            catch
            {
            }
        }
    }
}
