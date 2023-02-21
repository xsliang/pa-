using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D163
    {
        public static void D163Main()
        {
            var line = Console.ReadLine();
            if (line.Length >= 1 && line.Length <= 100)
            {
                foreach (var item in line)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
