using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D154
    {
        public static void D154Main()
        {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            var line2 = Console.ReadLine();
            int m = int.Parse(line2);
            if (n >= 1 && n <= 10 && m >= 0 && m <= n * m)
            {
                Console.WriteLine(n * n - m);
            }
        }
    }
}
