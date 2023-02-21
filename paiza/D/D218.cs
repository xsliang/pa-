using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D218
    {
        public static void D218Main()
        {
            var line = Console.ReadLine();
            int N = int.Parse(line);
            if (N >= 0 && N <= 100000)
            {
                if (N>1000)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
