using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D182
    {
        public static void D182Main() {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            var line2 = Console.ReadLine();
            int m = int.Parse(line2);
            if (n>=1 && n<=1000 && m>=1 && m<=100)
            {
                Console.WriteLine(n/m);
            }
        }
    }
}
