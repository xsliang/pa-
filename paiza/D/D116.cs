using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D116
    {
        static void D116Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                double N = Convert.ToInt32(line);
                if (N >= 100 && N <= 100000)
                {
                    Console.WriteLine(N.ToString().Substring(0,N.ToString().Length-2)+"00");
                }
            }
            catch
            {
            }
        }
    }
}
