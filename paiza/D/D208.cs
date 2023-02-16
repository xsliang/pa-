using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D208
    {
        public static void D208Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line.Split(' ')[0]);
            int b = int.Parse(line.Split(' ')[1]);
            if (a >= 100 && a <= 20000 && b >= 100 && b <= 20000 && a>=b)
            {
                Console.WriteLine(a-b);
            }
        }
    }
}
