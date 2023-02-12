using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D224
    {
        public static void D224Main()
        {
            var line = Console.ReadLine();
            if (line.Length >= 1 && line.Length <= 500)
            {
                Console.WriteLine(line + line + line);
            }
        }
    }
}
