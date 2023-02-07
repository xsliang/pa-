using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D172
    {
        public static void D172Main() {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            if (N>=2 && N<=31)
            {
                Console.WriteLine(N-1);
            }
        }
    }
}
