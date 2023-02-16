using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D181
    {
        public static void D181Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line);
            var line2 = Console.ReadLine();
            int b = int.Parse(line2);
            var line3 = Console.ReadLine();
            int c = int.Parse(line3);
            if (a >= 1 && a <= 9999 && b >= 1 && b <= 9999 && c >= 1 && c <= 9999)
            {
                Console.WriteLine(a +"-"+ b + "-" + c);
            }
        }
    }
}
