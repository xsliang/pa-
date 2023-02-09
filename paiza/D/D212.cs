using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D212
    {
        public static void D212Main() {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            if (N>=0 && N<=100)
            {
                Console.WriteLine(N*10);
            }
        }
    }
}
