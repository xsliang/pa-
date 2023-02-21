using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D150
    {
        public static void D150Main()
        {
            var line = Console.ReadLine();
            int x = int.Parse(line);
            var line2 = Console.ReadLine();
            int y = int.Parse(line2);
            if (x >= 1 && x <= 10000000 && y >= 1 && y <= 10000000)
            {
                if (x<y)
                {
                    Console.WriteLine(y-x);
                }
                else
                {
                    Console.WriteLine("Thank you");
                }
            }
        }
    }
}
