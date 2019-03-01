using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D118
    {
        static void D118Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();
                int n = Convert.ToInt32(line2);
                if (line == "S")
                {
                    if (n >= 1 && n <= 64)
                    {
                        Console.WriteLine((1926 + (n - 1)));
                    }
                }
                else if (line == "H")
                {
                    if (n >= 1 && n <= 31)
                    {
                        Console.WriteLine((1989 + (n - 1)));
                    }
                }
            }
            catch
            {
            }
        }
    }
}
