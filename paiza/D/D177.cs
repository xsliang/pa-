using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D177
    {
        public static void D177Main()
        {
            var line = Console.ReadLine();
            int a = int.Parse(line.Split(' ')[0]);
            int b = int.Parse(line.Split(' ')[1]);
            if (a >= 1 && a <= 2000 && b >= 1 && b <= 20)
            {
                Console.WriteLine(a*b);
            }
        }
    }
}
