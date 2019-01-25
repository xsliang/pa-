using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D115
    {
        static void D115Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                double N = Convert.ToInt32(line);
                if (N >= 2 && N <= 50)
                {
                    Console.WriteLine(N / 2);
                }
            }
            catch
            {
            }
        }
    }
}
