using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D171
    {
        public static void D171Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line.Split(' ')[0]);
            int b = int.Parse(line.Split(' ')[1]);
            var line2 = Console.ReadLine();
            int N = int.Parse(line2);

            if (a >= 1 && a <= 100 && b >= 1 && b <= 100 && N >= 1 && N <= 100)
            {
                Console.WriteLine((a-N) + " " + (b-N));

            }
        }
    }
}
