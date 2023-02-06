using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D228
    {
        static void D228Main()
        {
            string sh = Console.ReadLine();
            string tm = Console.ReadLine();
            int s = int.Parse(sh.Split(' ')[0]);
            int h = int.Parse(sh.Split(' ')[1]);
            int t = int.Parse(tm.Split(' ')[0]);
            int m = int.Parse(tm.Split(' ')[1]);

            if (s >= 0 && s <= 23 && t >= 0 && t <= 23 && h >= 0 && h <= 59 && m >= 0 && m <= 59)
            {
                if (t > s)
                {
                    Console.WriteLine("No");
                }
                else if (h == s && m > t)
                {
                    Console.WriteLine("No");
                }
                else
                {
                    Console.WriteLine("Yes");
                }
            }
        }
    }
}
