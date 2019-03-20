using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D119
    {
        static void D119Main()
        {
            try
            {
                string pi = "3.141592653589793";
                var line = System.Console.ReadLine();
                int n = Convert.ToInt32(line);
                if (n >= 1 && n <= 15)
                {
                    Console.WriteLine(pi.Substring(0, n + 2));
                }
            }
            catch
            {
            }
        }
    }
}
