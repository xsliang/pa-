using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D206
    {
        public static void D206Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line.Split(' ')[0]);
            int b = int.Parse(line.Split(' ')[1]);
            if (a >= 1 && a <= 100 && b >= 1 && b <= 100)
            {
                Console.WriteLine(b + " " + a);
            }
        }
    }
}
