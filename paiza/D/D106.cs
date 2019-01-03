using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D106
    {
        public static void D106Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                int M = Convert.ToInt32(line2);
                if (N >= 1 && N <= 100 && M >= 1 && M <= 100 && M < N)
                {
                    System.Console.WriteLine(N % M);
                }
            }
            catch
            {

            }
        }
    }
}
