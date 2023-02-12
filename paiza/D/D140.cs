using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D140
    {
        public static void D140Main()
        {
            var line = Console.ReadLine();
            int D = int.Parse(line);
            var line2 = Console.ReadLine();
            if (D >= 1 && D <= 10)
            {
                string[] result = line2.Split(' ');
                Console.WriteLine(result[D - 1]);
            }
        }
    }
}
