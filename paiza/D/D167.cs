using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D167
    {
        public static void D167Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line);
            if (a >= 1 && a <= 5000)
            {
                if (a>=1000)
                {
                    Console.WriteLine(a + 3);
                }
                else {
                    Console.WriteLine(a);
                }
                
            }
        }
    }
}
