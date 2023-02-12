using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D204
    {
        public static void D204Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line);
            if (a >= 1 && a <= 221)
            {
                Console.WriteLine(222 - a);
            }
        }
    }
}
