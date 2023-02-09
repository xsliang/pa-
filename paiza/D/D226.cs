using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D226
    {
        public static void D226Main() {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            if (n>=0 && n<=100)
            {
                Console.WriteLine(170+n);
            }
        }
    }
}
