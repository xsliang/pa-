using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D170
    {
        public static void D170Main() {
            string line1 = Console.ReadLine();
            string line2 = Console.ReadLine();
            int N = int.Parse(line2);
            int M = int.Parse(line1);
            
            if (M>=1 && M<=100 && N>=10 && N<=1000)
            {
                Console.WriteLine(M * N);
            }
        }
    }
}
