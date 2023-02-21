using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D151
    {
        public static void D151Main()
        {
            var line = Console.ReadLine();
            var line2 = Console.ReadLine();
            int N = int.Parse(line2);
            if (N >= 1 && N <= 1000)
            {
                if (line== "chocolate")
                {
                    Console.WriteLine(N * 2);
                }
                else if (line == "cake") {
                    Console.WriteLine(N * 5);
                }
            }
        }
    }
}
