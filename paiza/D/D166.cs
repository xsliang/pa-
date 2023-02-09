using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D166
    {
        public static void D166Main() {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            if (n>=1 && n<=52)
            {
                Console.WriteLine(n*7);
            }
        }
    }
}
