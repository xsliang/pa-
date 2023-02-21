using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D186
    {
        public static void D186Main()
        {
            var line = Console.ReadLine();
            int t = int.Parse(line);
            if (t >= 1 && t <= 50)
            {
                if (t>=30 && t<35)
                {
                    Console.WriteLine("M");
                }
                else {
                    Console.WriteLine(t);
                }
            }
        }
    }
}
