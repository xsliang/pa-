using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D202
    {
        public static void D202Main()
        {
            var line = Console.ReadLine();
            int p1 = int.Parse(line.Split(' ')[0]);
            int f1 = int.Parse(line.Split(' ')[1]);
            var line2 = Console.ReadLine();
            int p2 = int.Parse(line2.Split(' ')[0]);
            int f2 = int.Parse(line2.Split(' ')[1]);
            if (p1 >= 100 && p1 <= 10000 && p2 >= 100 && p2 <= 10000 &&
                f1 >= 0 && f1 <= 1000 && f2 >= 0 && f2 <= 1000)
            {
                if (p1+f1>=p2+f2)
                {
                    Console.WriteLine(p2 + f2);
                }
                else {
                    Console.WriteLine(p1 + f1);
                }
            }
        }
    }
}
