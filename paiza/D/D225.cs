using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D225
    {
        public static void D225Main() {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            if (N>=0 && N<=10000)
            {
                Console.WriteLine(N*3);
            }
        }
    }
}
