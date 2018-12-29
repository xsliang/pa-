
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D080
    {
        public static void D080Main()
        {
            
            

            var line = System.Console.ReadLine();

            int n = Convert.ToInt32(line.Split(' ')[0]);
            int m = Convert.ToInt32(line.Split(' ')[1]);
            if (n < 1 || n > 100 || m < 1 || m > 100)
            {
                return;
            }



            System.Console.WriteLine(n * 6000 + (m * 4000));
        }
    }
}
