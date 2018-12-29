

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D083
    {
        public static void D083Main()
        {
            var line = System.Console.ReadLine();

            int M = Convert.ToInt32(line.Split(' ')[0]);
            int N = Convert.ToInt32(line.Split(' ')[1]);

            if (M < 1 || M > 13 || N < 1 || N > 13)
            {
                return;
            }

            if (N + M < 16)
            {
                Console.WriteLine("HIT");
            }
            else
            {
                Console.WriteLine("STAND");
            }
        }
    }
}
