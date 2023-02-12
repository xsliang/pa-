using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D221
    {
        public static void D221Main() {
            var line = Console.ReadLine();
            int n = int.Parse(line);
            if (n>=0 && n<=10000)
            {
                Console.WriteLine(n/2);
            }
        }
    }
}
