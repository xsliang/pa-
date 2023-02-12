using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D229
    {
        public static void D229Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            if (N >= 10 && N <= 100)
            {
                Console.WriteLine(N - 10);
            }
        }
    }
}
