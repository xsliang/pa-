using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D160
    {
        public static void D160Main()
        {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            var line2 = Console.ReadLine();
            int m = int.Parse(line2);
            if (n >= 10 && n <= 5000 && m >= 1 && m <= 10 && n % 10 == 0)
            {
                Console.WriteLine(n / 10 * m);
            }
        }
    }
}
