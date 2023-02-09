using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D185
    {
        public static void D185Main() {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            var line2 = Console.ReadLine();
            int m = int.Parse(line2);
            if (n>=1100 && n<=5000 && m>=1 && m<=200)
            {
                Console.WriteLine(m*n);
            }
        }
    }
}
