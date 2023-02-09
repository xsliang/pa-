using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D179
    {
        public static void D179Main() {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            var line2 = Console.ReadLine();
            int m = int.Parse(line2);
            if (n>=2 && n<=10 && m>=1 && m<=100 && n<m)
            {
                Console.WriteLine(m%n);
            }
        }
    }
}
