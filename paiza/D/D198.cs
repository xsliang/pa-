using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    public class D198
    {
        public static void D198Main() {
            var line = Console.ReadLine();
            int a = int.Parse(line);
            var line2 = Console.ReadLine();
            int b = int.Parse(line2);
            if (a>=1 && a<=100 && b >= 1 && b <= 100)
            {
                Console.WriteLine(a+"/"+b);
            }
        }
    }
}
