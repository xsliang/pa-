using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D108
    {
        public static void D108Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                decimal t = Convert.ToDecimal(line);
                if (t >= 1 && t <= 24)
                {
                    decimal result = Math.Ceiling(24 / t);
                    System.Console.WriteLine(result);
                }
            }
            catch
            {

            }
        }
    }
}
