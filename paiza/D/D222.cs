using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D222
    {
        public static void D222Main()
        {
            var line = Console.ReadLine();
            int X = int.Parse(line);
            var line2 = Console.ReadLine();
            int Y = int.Parse(line2);
            if (X >= 0 && X <= 500 && Y >= 0 && Y <= 500 && X!=Y)
            {
                if (X>Y)
                {
                    Console.WriteLine(X);
                }
                else
                {
                    Console.WriteLine(Y);
                }
            }
        }
    }
}
