using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D156
    {
        public static void D156Main() {
            var line1 = Console.ReadLine();
            int a = int.Parse(line1);
            var line2 = Console.ReadLine();
            int b = int.Parse(line2);
            if (a>=1 && a<=100 && b >= 1 && b <= 100)
            {
                Console.WriteLine(a*b);
            }
        }
    }
}
