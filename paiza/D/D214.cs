using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D214
    {
        public static void D214Main() {
            var line1 = Console.ReadLine();
            int a = int.Parse(line1);
            var line2 = Console.ReadLine();
            int b = int.Parse(line2);
            if (a>=1 && a<=300 && b >= 1 && b <= 300 && b<=a)
            {
                Console.WriteLine(a-b);
            }
        }
    }
}
