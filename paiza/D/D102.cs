using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D102
    {
        public static void D102Main()
        {
            try
            {
                var line = System.Console.ReadLine();
                int N = Convert.ToInt32(line);
                if (N >= 1 && N <= 30)
                {
                    System.Console.WriteLine((100 + 10 * (N)).ToString());
                }
            }
            catch
            {
            }
        }
    }
}
