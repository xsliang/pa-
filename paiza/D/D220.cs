using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D220
    {
        public static void D220Main()
        {
            var line = Console.ReadLine();
            var line2 = Console.ReadLine();
            int a = int.Parse(line);
            int b = int.Parse(line2);
            if (a >= 0 && a <= 500 && b >= 0 && b <= 500)
            {
                Console.WriteLine(a + b);
            }
        }
    }
}
