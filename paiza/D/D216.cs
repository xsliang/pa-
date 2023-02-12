using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D216
    {
        public static void D216Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line);
            var line2 = Console.ReadLine();
            int b = int.Parse(line2);
            if (a >= 0 && a <= 500 && b >= 0 && b <= 500 && (a + b) <= 500)
            {
                Console.WriteLine(500 - a - b);
            }
        }
    }
}
