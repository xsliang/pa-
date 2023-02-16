using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D169
    {
        public static void D169Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line.Split(' ')[0]);
            int b = int.Parse(line.Split(' ')[1]);
            if (a >= 0 && a <= 35 && b >= 0 && b <= 35)
            {
                Console.WriteLine(a - b);
            }
        }
    }
}
