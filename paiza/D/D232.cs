using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D232
    {
        public static void D232Main() {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            if (n>=1 && n<=500)
            {
                Console.WriteLine(n*100);
            }
        }
    }
}
