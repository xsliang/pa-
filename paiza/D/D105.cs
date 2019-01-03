using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D105
    {
        public static void D105Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                var line2 = System.Console.ReadLine();
                if (line.Length >= 1 && line.Length <= 100 && line2.Length >= 1 && line2.Length <= 100)
                {
                    if (line.Length == line2.Length)
                    {
                        System.Console.WriteLine("Yes");
                    }
                    else
                    {
                        System.Console.WriteLine("No");
                    }
                }
            }
            catch
            {

            }
        }
    }
}
