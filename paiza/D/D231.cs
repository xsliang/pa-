using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D231
    {
        public static void D231Main()
        {
            var line = Console.ReadLine();
            if (line.Length >= 2 && line.Length <= 300)
            {
                Console.WriteLine(line.Substring(1,1));
            }
        }
    }
}
