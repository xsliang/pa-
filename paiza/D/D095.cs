using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D095
    {
        public static void D095Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();

                decimal N = Convert.ToDecimal(line);
                decimal M = Convert.ToDecimal(line2);


                if (N >= 100 && N <= 2000 && M >= 100 && M <= 2000 && M <= N)
                {
                    decimal result = Math.Floor(N / M);

                    System.Console.WriteLine(result);
                }


            }
            catch
            {
            }


        }
    }
}
