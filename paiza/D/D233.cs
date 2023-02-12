using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D233
    {
        public static void D233Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line);
            var line2 = Console.ReadLine();
            int b = int.Parse(line2);
            var line3 = Console.ReadLine();
            int c = int.Parse(line3);
            if (a >= 0 && a <= 500 && b >= 0 && b <= 500 && c >= 0 && c <= 500)
            {
                Console.WriteLine(a + b+c);
            }
        }
    }
}
