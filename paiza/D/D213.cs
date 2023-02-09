using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D213
    {
        public static void D213Main() {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            if (N>=1 && N<=9999)
            {
                Console.WriteLine(N*365);
            }
        }
    }
}
