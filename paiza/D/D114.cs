using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D114
    {
        static void D114Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                double a = Convert.ToDouble(line.Split(' ')[0]) * 0.01;
                double b = Convert.ToDouble(line.Split(' ')[1]) ;

                if (a >= 0 && a <= 50 && b >= 1 && b <= 10000)
                {
                    decimal result = Math.Floor(Convert.ToDecimal(b) + Convert.ToDecimal(b) * Convert.ToDecimal(a));

                    Console.WriteLine(result);
                }
            }
            catch
            {
            }
        }
    }
}
