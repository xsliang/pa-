using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D235
    {
        public static void D235Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line);

            if (a >= 1 && a <= 150)
            {
                Console.WriteLine(a*5);

            }
        }
    }
}
