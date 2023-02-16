using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D145
    {
        public static void D145Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line.Split(' ')[0]);
            int M = int.Parse(line.Split(' ')[1]);

            if (N >= 0 && N <= 100 && M >= 1 && M <= 100)
            {

                Console.WriteLine(N / M);

            }
        }
    }
}
