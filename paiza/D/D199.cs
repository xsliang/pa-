using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D199
    {
        public static void D199Main() {
            var line = Console.ReadLine();
            int m = int.Parse(line);
            var line2 = Console.ReadLine();
            int n = int.Parse(line2);
            if (n>=1 && n<=10 && m >= 1 && m <= 10)
            {
                Console.WriteLine(n*m);
            }
        }
    }
}
