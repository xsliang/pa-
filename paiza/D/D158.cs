using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D158
    {
        public static void D158Main()
        {
            var line = Console.ReadLine();
            int t = int.Parse(line);
            if (t >= 1 && t <= 100)
            {
                if (t >= 40 && t <= 60)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("NG");
                }
            }
        }
    }
}
