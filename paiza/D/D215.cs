using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paiza.D
{
    class D215
    {
        public static void D215Main()
        {
            var line = Console.ReadLine();
            if (line.Length >= 1 && line.Length <= 300)
            {
                if (line == "paiza")
                {
                    Console.WriteLine("Yes");
                }
                else {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
