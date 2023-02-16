using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D234
    {
        public static void D234Main()
        {
            var line = Console.ReadLine();
            if (line.Length>=1 && line.Length<=10)
            {
                Console.WriteLine(10-line.Length);
            }
        }
    }
}
