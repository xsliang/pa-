using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D223
    {
        public static void D223Main()
        {
            var line = Console.ReadLine();
            var line2 = Console.ReadLine();
            if (line.Length >= 1 && line.Length <= 100 && line.Length >= 1 && line.Length <= 100)
            {
                Console.WriteLine(line + line2);
            }
        }
    }
}
