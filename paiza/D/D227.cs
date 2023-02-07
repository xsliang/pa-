using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D227
    {
        public static void D227Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            if (N>=1 && N<=5000000)
            {
                Console.WriteLine(N-120);
            }
            

        }
    }
}
