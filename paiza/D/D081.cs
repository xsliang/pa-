

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D081
    {
        public static void D081Main()
        {
            
            

            var line = System.Console.ReadLine();
            var line2 = System.Console.ReadLine();
            int N = Convert.ToInt32(line);
            if (N < 2 || N > 10)
            {
                return;
            }
            int H = Convert.ToInt32(line2.Split(' ')[0]);
            int W = Convert.ToInt32(line2.Split(' ')[1]);
            if (H < 1 || H > 50 || W < 1 || W > 50)
            {
                return;
            }
            System.Console.WriteLine((H * W) % N);
        }
    }
}
