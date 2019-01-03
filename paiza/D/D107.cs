using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D107
    {
        public static void D107Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();
                if (line.Length >= 2 && line.Length <= 100 && line2.Length == 1)
                {
                    System.Console.WriteLine(line2+ line+ line2);
                }
            }
            catch
            {

            }
        }
    }
}
