
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D067
    {
        public static void D067Main()
        {
            var line = System.Console.ReadLine();
            try
            {
                int n = Convert.ToInt32(line);
                if (1 <= n && n <= 100)
                {
                    if (n % 2 == 0)
                    {
                        System.Console.WriteLine("OFF");
                    }
                    else
                    {
                        System.Console.WriteLine("ON");
                    }
                }

            }
            catch
            {
            }

        }
    }
}
