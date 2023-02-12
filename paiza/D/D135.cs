using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D135
    {
        public static void D135Main()
        {
            var line = Console.ReadLine();
            int D = int.Parse(line);
            if (D >= 180 && D <= 18000 && D % 180 == 0)
            {
                Console.WriteLine((D / 180) + 2);
            }
        }
    }
}
